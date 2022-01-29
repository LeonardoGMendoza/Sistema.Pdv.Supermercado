using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class ProdutoPedido
    {
        int idProdutoPedido;
        int codPedido;
        int codProduto;
        string codBarras;
        int quantidadeItemPedido;
        decimal totalProdutoPedido;
        public int IdProdutoPedido { get {return  idProdutoPedido; } set {idProdutoPedido = value; } }
        public int CodPedido { get{return codPedido;} set{codPedido = value;} }
        public int CodProduto { get{return codProduto;} set{codProduto = value;} }
        public string CodBarras { get{return codBarras;} set{ codBarras = value;} }

        public int QuantidadeItemPedido { get{return quantidadeItemPedido;} set{quantidadeItemPedido = value;} }
        public decimal TotalProdutoPedido { get{return totalProdutoPedido;} set{ totalProdutoPedido = value;} }



    }
}
