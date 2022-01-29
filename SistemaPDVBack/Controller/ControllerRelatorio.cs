using System.Data.SqlClient;
using SistemaPDVBack.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Controller
{

    class ControllerRelatorio
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        Relatorio relatorio = new Relatorio();
        public List<string> ListaProduto = new List<string>();

        SqlDataReader reader;
        public ControllerRelatorio()
        {

        }

        public ControllerRelatorio(string dataInicial, string dataFinal)
        {

            relatorio.DataInicial = dataInicial;
            relatorio.DataFinal = dataFinal;
        }

        public DataTable BuscarPorData()
        {
            try
            {
                cmd.CommandText = "SELECT idPedido, dataDoPedido, formaPagamento, totalPedido FROM pedido WHERE dataDoPedido like '%' and STR_TO_DATE(dataDoPedido, '%d/%m/%Y') BETWEEN STR_TO_DATE(@dataInicial, '%d/%m/%Y') AND STR_TO_DATE(@dataFinal, '%d/%m/%Y')";
                cmd.Parameters.AddWithValue("@dataInicial", relatorio.DataInicial);
                cmd.Parameters.AddWithValue("@dataFinal", relatorio.DataFinal);
                cmd.Connection = conexao.AbrirBanco();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dtLista = new DataTable();


                da.Fill(dtLista);


                return (dtLista);
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                cmd.Parameters.Clear();
                conexao.FecharBanco();
            }
        }

        public DataTable BuscarPorProdutos(string id)
        {
            relatorio.Id = id;
            cmd.CommandText = "select pp.quantidadeItemPedido, p.nomeProduto, p.precoVenda,  pp.totalProdutoPedido from ProdutoPedido pp join Produto p on pp.codProduto = p.idProduto join Pedido pe  on pe.idPedido = pp.codPedido  where pe.idpedido = @idPedido;  ";
            cmd.Parameters.AddWithValue("@idPedido", relatorio.Id);

            try
            {
                cmd.Connection = conexao.AbrirBanco();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dtLista = new DataTable();
                da.Fill(dtLista);
                return (dtLista);

            }
            catch (Exception e)
            {
                throw;
                //MessageBox.Show(e.Message);

            }
            finally
            {
                conexao.FecharBanco();
                cmd.Parameters.Clear();
            }
        }

    }
}
