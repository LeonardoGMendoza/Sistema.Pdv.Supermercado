using System;
using System.Collections.Generic;

namespace CleanArch.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ColaboradorId { get; set; }
        public int? ClienteId { get; set; }
        public int Status { get; set; }
        public DateTime DataPedido { get; set; }
        public string FormaPagamento { get; set; }
        public decimal Total { get; set; }

        public ICollection<PedidoItem> Itens { get; set; } = new List<PedidoItem>();
    }
}
