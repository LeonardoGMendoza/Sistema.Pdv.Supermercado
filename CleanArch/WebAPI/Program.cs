using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CleanArch.Infrastructure.Data;
using CleanArch.Infrastructure.Persistence;
using CleanArch.Domain.Interfaces;
using CleanArch.Application.Services;
using MassTransit;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// 1. Configurar PostgreSQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql("Host=localhost;Database=SistemaPDV;Username=leouser;Password=leopassword"));

// 2. Configurar Injeção de Dependência
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<PedidoService>();

// 3. Configurar RabbitMQ (MassTransit)
builder.Services.AddMassTransit(x =>
{
    x.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host("localhost", "/", h => {
            h.Username("guest");
            h.Password("guest");
        });
    });
});

builder.Services.AddControllers();

// 4. Configurar Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mercadinho Gil PDV API", Version = "v1" });
});

var app = builder.Build();

// Ativar Swagger
if (app.Environment.IsDevelopment() || true) // Forçamos true para você ver no teste
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mercadinho Gil API v1"));
}

app.UseRouting();
app.MapControllers();

app.Run();
