using System;

namespace CleanArch.Domain.Events
{
    public class PedidoCriadoEvent
    {
        public int PedidoId { get; set; }
        public DateTime DataCriacao { get; set; }
        public decimal Total { get; set; }

        public PedidoCriadoEvent(int pedidoId, decimal total)
        {
            PedidoId = pedidoId;
            DataCriacao = DateTime.UtcNow;
            Total = total;
        }
    }
}
