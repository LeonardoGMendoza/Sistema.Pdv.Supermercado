using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.DTO
{



    class ProdutoPedidoDTO
    {
        public string CodigoItem { get; set; }

        public string CodBarras { get; set; }
        public string NomeProduto { get; set; }
        public string PrecoUnit { get; set; }
        public string Quantidade{ get; set; }
        public string Total { get; set; }
        public string StatusAtivo { get; set; }

        public ProdutoPedidoDTO()
        {

        }

        public ProdutoPedidoDTO(string codItem ,string codBarras, string nomeProduto, string quantidade, string precoUnit,  string total, string statusAtivo )
        {

            CodBarras = codBarras;
            CodigoItem = codItem;
            NomeProduto = nomeProduto;
            PrecoUnit = precoUnit;
            Quantidade = quantidade;
            Total = total;
            StatusAtivo = statusAtivo;
        }
    }
}
