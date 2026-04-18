using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using CleanArch.Infrastructure.Data;
using CleanArch.Infrastructure.Persistence;
using CleanArch.Domain.Interfaces;
using CleanArch.Application.Services;
using MassTransit;
using Microsoft.OpenApi.Models;
using System;

var builder = WebApplication.CreateBuilder(args);

// 1. Configurar PostgreSQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Configurar CORS (Liberar Geral)
builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll", policy => {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader()
              .SetIsOriginAllowed(origin => true); // Liberar qualquer origem!
    });
});

// 3. Configurar Injeção de Dependência
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<PedidoService>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<ProdutoService>();

// 4. Configurar RabbitMQ (MassTransit)
builder.Services.AddMassTransit(x =>
{
    x.UsingRabbitMq((context, cfg) =>
    {
        var rabbitHost = builder.Configuration["RabbitMQ:Host"] ?? "localhost";
        cfg.Host(rabbitHost, "/", h => {
            h.Username("guest");
            h.Password("guest");
        });
    });
});

builder.Services.AddControllers();

// 5. Configurar Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mercadinho Gil PDV API", Version = "v1" });
});

var app = builder.Build();

// --- Garantir que o banco de dados foi criado e os produtos foram injetados ---
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var logger = services.GetRequiredService<ILogger<Program>>();
    var context = services.GetRequiredService<ApplicationDbContext>();
    
    int retries = 5;
    while (retries > 0)
    {
        try
        {
            logger.LogInformation("Tentando conectar ao banco de dados... (Tentativas restantes: {retries})", retries);
            context.Database.EnsureCreated(); 
            logger.LogInformation("Banco de dados pronto e tabelas criadas!");
            break;
        }
        catch (Exception ex)
        {
            retries--;
            logger.LogWarning("O banco ainda não está pronto. Esperando 5 segundos...");
            System.Threading.Thread.Sleep(5000);
            if (retries == 0)
            {
                logger.LogError(ex, "Erro fatal: Não foi possível conectar ao banco de dados.");
            }
        }
    }
}

// 6. Configurar Pipeline
app.UseCors("AllowAll");

if (app.Environment.IsDevelopment() || true) 
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mercadinho Gil API v1"));
}

app.UseAuthorization();
app.MapControllers();

app.Run();
