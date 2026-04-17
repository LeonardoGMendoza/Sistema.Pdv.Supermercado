using System.Threading.Tasks;
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
            // 1. Salva no Banco de Dados (PostgreSQL)
            await _repository.AddAsync(pedido);

            // 2. Notifica outros sistemas via RabbitMQ
            await _publishEndpoint.Publish(new PedidoCriadoEvent(pedido.Id, pedido.Total));
        }
    }
}
