using System.Threading.Tasks;
using System.Collections.Generic;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Events;
using MassTransit;

namespace CleanArch.Application.Services
{
    public class PedidoService
    {
        private readonly IPedidoRepository _repository;
        private readonly IPublishEndpoint _publishEndpoint;

        public PedidoService(IPedidoRepository repository, IPublishEndpoint publishEndpoint)
        {
            _repository = repository;
            _publishEndpoint = publishEndpoint;
        }

        public async Task CriarNovoPedido(Pedido pedido)
        {
            await _repository.AddAsync(pedido);
            await _publishEndpoint.Publish(new PedidoCriadoEvent(pedido.Id, pedido.Total));
        }

        public async Task<IEnumerable<Pedido>> ObterTodosPedidos()
        {
            return await _repository.GetAllAsync();
        }
    }
}
