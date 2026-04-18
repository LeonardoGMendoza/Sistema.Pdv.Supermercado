using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces
{
    public interface IPedidoRepository
    {
        Task<Pedido> GetByIdAsync(int id);
        Task<IEnumerable<Pedido>> GetAllAsync();
        Task AddAsync(Pedido pedido);
        Task UpdateAsync(Pedido pedido);
    }
}
