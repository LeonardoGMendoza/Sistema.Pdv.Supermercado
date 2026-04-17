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
        }
    }
}
