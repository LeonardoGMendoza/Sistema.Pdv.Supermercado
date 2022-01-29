using System.Data.SqlClient;
using SistemaPDVBack.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPDVBack.Controller
{
    class ControllerProdutoPedido
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        Conexao conexao = new Conexao();
        ProdutoPedido produtoPedido = new ProdutoPedido();

        public ControllerProdutoPedido(string codBarras, string quantidade, string total)
        {
            ConverterValidar(codBarras, quantidade, total);
            CarregaPedido();
            CarregaProduto();

        }

        private void ConverterValidar(string codBarras, string quantidade, string total)
        {
            try
            {
                if (!codBarras.Equals(""))
                {
                    produtoPedido.CodBarras = codBarras;

                }
                if (!quantidade.Equals(""))
                {
                    produtoPedido.QuantidadeItemPedido = int.Parse(quantidade);

                }

                if (!total.Equals(""))
                {

                    produtoPedido.TotalProdutoPedido = decimal.Parse(total);
                }
            }
 

            catch (Exception e)
            {
                throw;
            }


        }

        public string VerificaProdutoPreco()
        {


            cmd.CommandText = "select *from Produto where codBarras = @codBarras and statusAtivo = 1";
            cmd.Parameters.AddWithValue("@codBarras", produtoPedido.CodBarras);

            string venda = "";
            try
            {
                cmd.Connection = conexao.AbrirBanco();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    venda = reader.GetString(6);

                }
                return venda;


            }
            catch (Exception e)
            {
                throw;
          
            }
            finally
            {
                conexao.FecharBanco();
                cmd.Parameters.Clear();

            }

        }

        public void AtualizaEstoque()
        {

            cmd.CommandText = "update Produto set quantidadeEstoqueProduto  = quantidadeEstoqueProduto - @quantidadeProduto where idProduto = @idProduto";
            cmd.Parameters.AddWithValue("@quantidadeProduto", produtoPedido.QuantidadeItemPedido);
            cmd.Parameters.AddWithValue("@idProduto", produtoPedido.CodProduto);

            try
            {
                cmd.Connection = conexao.AbrirBanco();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                conexao.FecharBanco();
                cmd.Parameters.Clear();
            }
        }

        public string VerificaProdutoNome()

        {
            cmd.CommandText = "select *from Produto where codBarras = @codBarras and statusAtivo = 1";
            cmd.Parameters.AddWithValue("@codBarras", produtoPedido.CodBarras);

            string nome = "";
            try
            {
                cmd.Connection = conexao.AbrirBanco();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    nome = reader.GetString(3);

                }

                return nome;


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
        private void CarregaProduto()
        {

            cmd.CommandText = "select *from Produto where codBarras = @codBarras";
            cmd.Parameters.AddWithValue("@codBarras", produtoPedido.CodBarras);

            try
            {
                cmd.Connection = conexao.AbrirBanco();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    produtoPedido.CodProduto = reader.GetInt32(0);

                }

            }
            catch (Exception e)
            {
                throw;


            }
            finally
            {
                conexao.FecharBanco();
                cmd.Parameters.Clear();
            }

        }
        public void AdicionarProdutoPedido()
        {
            cmd.CommandText = "insert into ProdutoPedido(codPedido, codProduto, quantidadeItemPedido, totalProdutoPedido) values (@codPedido, @codProduto, @quantidadeItemPedido,@totalProdutoPedido)";
            cmd.Parameters.AddWithValue("@codPedido", produtoPedido.CodPedido);
            cmd.Parameters.AddWithValue("@codProduto", produtoPedido.CodProduto);
            cmd.Parameters.AddWithValue("@quantidadeItemPedido", produtoPedido.QuantidadeItemPedido);
            cmd.Parameters.AddWithValue("@totalProdutoPedido", produtoPedido.TotalProdutoPedido);

            try
            {
                cmd.Connection = conexao.AbrirBanco();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;

            }
            finally
            {
                cmd.Parameters.Clear();
                conexao.FecharBanco();
            }



        }

        public void CarregaPedido()
        {


            cmd.CommandText = "select idPedido from Pedido where idPedido= (select max(idPedido) from Pedido)";
            try
            {
                cmd.Connection = conexao.AbrirBanco();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        produtoPedido.CodPedido = reader.GetInt32(0);
                    }


                }
                else
                {

                }

            }
            catch (Exception e)
            {
                throw;

            }
            finally
            {
                conexao.FecharBanco();
            }
        }

    }
}
