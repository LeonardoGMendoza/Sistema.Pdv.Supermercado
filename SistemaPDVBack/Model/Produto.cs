using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Model
{
    class Produto
    {
        string codBarras;
        int idProduto;
        int codFornecedor;
        string nomeProduto;
        string descricaoProduto;
        decimal precoCusto;
        decimal precoVenda;
        decimal margemLucro;
        DateTime dataFabricao;
        DateTime dataVencimento;
        int quatidadeEstoqueProduto;
        string categoria;
        int statusAtivo;
        public string CodBarras { get{return codBarras ;} set{codBarras = value;} }
        public int IdProduto { get{return idProduto;} set{idProduto = value;} }
        public int CodFornecedor { get{return codFornecedor;} set{codFornecedor = value;} }
        public string NomeProduto { get{return nomeProduto ;} set{nomeProduto = value;} }
        public string DescricaoProduto { get{return descricaoProduto;} set{ descricaoProduto = value;} }
        public decimal PrecoCusto { get{return precoCusto;} set{ precoCusto = value;} }
        public decimal PrecoVenda { get{return precoVenda;} set{ precoVenda =value;} }
        public decimal MargemLucro { get{return margemLucro;} set{margemLucro = value;} }
        public DateTime  DataFabricacao { get{return dataFabricao;} set{ dataFabricao = value;} }
        public DateTime DataVencimento { get{return dataVencimento;} set{dataVencimento = value;} }
        public int QuantidadeEstoqueProduto { get{return quatidadeEstoqueProduto; } set{ quatidadeEstoqueProduto = value;} }
        public string Categoria { get{return categoria ;} set{categoria = value;} }
        public int StatusAtivo { get{return statusAtivo;} set{ statusAtivo = value;} }

       
    }


}
