using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Data;

namespace CleanArch.Infrastructure.Persistence
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ApplicationDbContext _context;

        public PedidoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task<Pedido> GetByIdAsync(int id)
        {
            return await _context.Pedidos.FindAsync(id);
        }

        public async Task<IEnumerable<Pedido>> GetAllAsync()
        {
            return await _context.Pedidos
                .OrderByDescending(p => p.DataPedido)
                .Take(50) // Pegamos os últimos 50 para o Dashboard
                .ToListAsync();
        }

        public async Task UpdateAsync(Pedido pedido)
        {
            _context.Pedidos.Update(pedido);
            await _context.SaveChangesAsync();
        }
    }
}
