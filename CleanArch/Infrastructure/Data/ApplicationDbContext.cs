using Microsoft.EntityFrameworkCore;
using CleanArch.Domain.Entities;

namespace CleanArch.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<PedidoItem> PedidoItens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Configurações de Fluent API (Senior gosta disso!)
            modelBuilder.Entity<Pedido>().HasKey(p => p.Id);
            modelBuilder.Entity<PedidoItem>().HasKey(pi => pi.Id);
            modelBuilder.Entity<Produto>().HasKey(p => p.Id);

            modelBuilder.Entity<Pedido>()
                .HasMany(p => p.Itens)
                .WithOne(pi => pi.Pedido)
                .HasForeignKey(pi => pi.PedidoId);

            // Injetando produtos para o teste do Gil
            modelBuilder.Entity<Produto>().HasData(
                new Produto { Id = 1, Nome = "Arroz Integral 5kg", Preco = 29.90m, CodigoBarras = "789123456", Estoque = 100, CategoriaId = 1, Descricao = "Arroz de alta qualidade" },
                new Produto { Id = 2, Nome = "Feijão Carioca 1kg", Preco = 8.50m, CodigoBarras = "789123457", Estoque = 50, CategoriaId = 1, Descricao = "Feijão novo" },
                new Produto { Id = 3, Nome = "Azeite de Oliva 500ml", Preco = 35.00m, CodigoBarras = "789123458", Estoque = 30, CategoriaId = 2, Descricao = "Extra Virgem" },
                new Produto { Id = 4, Nome = "Café Torrado 500g", Preco = 18.90m, CodigoBarras = "789123459", Estoque = 80, CategoriaId = 1, Descricao = "Forte" }
            );
        }
    }
}
