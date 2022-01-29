using System.Data.SqlClient;
using SistemaPDVBack.Model;


using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaPDVBack.Controller
{
    class ControllerProduto
    {
        private readonly SqlCommand cmd = new SqlCommand();
        private readonly string _inserir = "insert into Produto(codBarras, codFornecedor, nomeProduto, descricaoProduto,precoCusto,precoVenda,margemLucro,dataFabricacao,dataVencimento, quantidadeEstoqueProduto, categoria, statusAtivo)" +
                                            "values(@codBarras, @codFornecedor, @nomeProduto, @descricaoProduto, @precoCusto, @precoVenda, @margemLucro, @dataFabricacao, @dataVencimento, @quantidadeEstoqueProduto, @categoria, @statusAtivo ) ";

        private readonly string _alterar = "update Produto set codBarras = @codBarras, codFornecedor = @codFornecedor , nomeProduto = @nomeProduto, descricaoProduto = @descricaoProduto, precoCusto =@precoCusto, precoVenda = @precoVenda, margemLucro = @margemLucro, dataFabricacao = @dataFabricacao, dataVencimento = @dataVencimento, quantidadeEstoqueProduto = @quantidadeEstoqueProduto, categoria = @categoria, statusAtivo = @statusAtivo where idProduto = @idProduto ";
        private readonly string _listar = "select p.idProduto, p.codBarras, p.nomeProduto, f.nomeFantasia, p.descricaoProduto,p.quantidadeEstoqueProduto, p.precoCusto, p.margemLucro, p.precoVenda, p.dataFabricacao, p.dataVencimento, p.categoria, p.statusAtivo  From Produto p join Fornecedor f on p.codFornecedor = f.idFornecedor where p.statusAtivo = 1";
        string mensagem = "";

        public string Ds_Msg
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        Conexao conexao = new Conexao();
        Produto produto = new Produto();
        public ControllerProduto()
        {

        }
        public ControllerProduto(string codBarras)
        {
            if (codBarras != "")
            {
                produto.CodBarras = codBarras;

            }
        }



        public ControllerProduto(string idProduto, string codBarras, string codFornecedor, string nomeProduto, string descricaoProduto, string precoCusto, string precoVenda, string margemLucro, string dataFabricacao, string dataVencimento, string quantidadeEstoqueProduto, string categoria, string statusAtivo)
        {

            ConverterValidar(idProduto, codBarras, codFornecedor, nomeProduto, descricaoProduto, precoCusto, precoVenda, margemLucro, dataFabricacao, dataVencimento, quantidadeEstoqueProduto, categoria, statusAtivo);


        }
        private void ConverterValidar(string idProduto, string codBarras, string codFornecedor, string nomeProduto, string descricaoProduto, string precoCusto, string precoVenda, string margemLucro, string dataFabricacao, string dataVencimento, string quantidadeEstoqueProduto, string categoria, string statusAtivo)
        {

            string validarData = "(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/(19|20)\\d{2}";

            string validar = "Preencha os produtos";
            if (mensagem == "")
            {
                try
                {
                    if (idProduto != "")
                    {
                        produto.IdProduto = int.Parse(idProduto);
                    }

                    if(codBarras.Length > 14)
                    {
                        mensagem = "Tamanho do código invalido!!";
                    }
                    else
                    {
                        produto.CodBarras = codBarras;

                    }

                    if (nomeProduto != "" && descricaoProduto != "" && dataFabricacao != "" && dataVencimento != "" && categoria != "")
                    {
                        produto.DescricaoProduto = descricaoProduto;
                        produto.NomeProduto = nomeProduto;
                        produto.Categoria = categoria;

                    }
                    else
                    {
                        mensagem = validar;

                    }
                    if (Regex.IsMatch(dataFabricacao, validarData) || dataFabricacao == "00/00/0000")
                    {
                        produto.DataFabricacao = Convert.ToDateTime(dataFabricacao);

                    }
                    else
                    {
                        mensagem = "formato incorreto";
                    }

                    if (Regex.IsMatch(dataVencimento, validarData) || dataVencimento == "00/00/0000")
                    {
                        produto.DataVencimento = Convert.ToDateTime(dataVencimento);

                    }
                    else
                    {
                        mensagem = "formato incorreto";
                    }

                    produto.CodFornecedor = int.Parse(codFornecedor);
                    produto.PrecoCusto = decimal.Parse(precoCusto);
                    produto.PrecoVenda = decimal.Parse(precoVenda);
                    produto.MargemLucro = decimal.Parse(margemLucro);
                    produto.QuantidadeEstoqueProduto = int.Parse(quantidadeEstoqueProduto);
                    produto.StatusAtivo = int.Parse(statusAtivo);


                }


                catch (Exception e)
                {
                    mensagem = e.Message;
                }
            }
        }

        public void AdicionarProduto()
        {
            if (mensagem == "")
            {

                cmd.CommandText = _inserir;

                cmd.Parameters.AddWithValue("@codBarras", produto.CodBarras);
                cmd.Parameters.AddWithValue("@codFornecedor", produto.CodFornecedor);
                cmd.Parameters.AddWithValue("@nomeProduto", produto.NomeProduto);
                cmd.Parameters.AddWithValue("@descricaoProduto", produto.DescricaoProduto);
                cmd.Parameters.AddWithValue("@precoCusto", produto.PrecoCusto);
                cmd.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
                cmd.Parameters.AddWithValue("@margemLucro", produto.MargemLucro);
                cmd.Parameters.AddWithValue("@dataFabricacao", produto.DataFabricacao);
                cmd.Parameters.AddWithValue("@dataVencimento", produto.DataVencimento);
                cmd.Parameters.AddWithValue("@quantidadeEstoqueProduto", produto.QuantidadeEstoqueProduto);
                cmd.Parameters.AddWithValue("@categoria", produto.Categoria);
                cmd.Parameters.AddWithValue("@statusAtivo", produto.StatusAtivo);

                try
                {
                    cmd.Connection = conexao.AbrirBanco();
                    cmd.ExecuteNonQuery();


                }
                catch (Exception e)
                {
                    mensagem = e.Message;

                }
                finally
                {
                    cmd.Parameters.Clear();
                    conexao.FecharBanco();
                }
            }

        }


        public void AlterarProduto()
        {
            if (mensagem == "")
            {


                cmd.CommandText = _alterar;

                cmd.Parameters.AddWithValue("@idProduto", produto.IdProduto);
                cmd.Parameters.AddWithValue("@codBarras", produto.CodBarras);
                cmd.Parameters.AddWithValue("@codFornecedor", produto.CodFornecedor);
                cmd.Parameters.AddWithValue("@nomeProduto", produto.NomeProduto);
                cmd.Parameters.AddWithValue("@descricaoProduto", produto.DescricaoProduto);
                cmd.Parameters.AddWithValue("@precoCusto", produto.PrecoCusto);
                cmd.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
                cmd.Parameters.AddWithValue("@margemLucro", produto.MargemLucro);
                cmd.Parameters.AddWithValue("@dataFabricacao", produto.DataFabricacao);
                cmd.Parameters.AddWithValue("@dataVencimento", produto.DataVencimento);
                cmd.Parameters.AddWithValue("@quantidadeEstoqueProduto", produto.QuantidadeEstoqueProduto);
                cmd.Parameters.AddWithValue("@categoria", produto.Categoria);
                cmd.Parameters.AddWithValue("@statusAtivo", produto.StatusAtivo);

                try
                {
                    cmd.Connection = conexao.AbrirBanco();
                    cmd.ExecuteNonQuery();


                }
                catch (Exception e)
                {
                    mensagem = e.Message;

                }
                finally
                {
                    cmd.Parameters.Clear();
                    conexao.FecharBanco();
                }
            }



        }


        public DataTable ListarProduto()
        {
            cmd.CommandText = _listar;
            try
            {
                cmd.Connection = conexao.AbrirBanco();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtLista = new DataTable();
                da.Fill(dtLista);
                return dtLista;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                conexao.FecharBanco();
            }

        }


        public DataTable PesquisaProduto()
        {
            cmd.CommandText = "select p.idProduto, p.codBarras, p.nomeProduto, f.nomeFantasia, p.descricaoProduto,p.quantidadeEstoqueProduto, p.precoCusto, p.margemLucro, p.precoVenda, p.dataFabricacao, p.dataVencimento, p.categoria, p.statusAtivo  From Produto p join Fornecedor f on p.codFornecedor = f.idFornecedor where p.codBarras LIKE'%' @codBarras '%' order by p.codBarras";
            cmd.Parameters.AddWithValue("@codBarras", produto.CodBarras);
            try
            {
                cmd.Connection = conexao.AbrirBanco();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtLista = new DataTable();
                da.Fill(dtLista);
                return dtLista;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                conexao.FecharBanco();
            }

        }
        public DataTable PreencherFornecedor()
        {
            cmd.CommandText = "Select *from Fornecedor where statusAtivo = 1";
            try
            {
                cmd.Connection = conexao.AbrirBanco();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtLista = new DataTable();
                da.Fill(dtLista);
                return dtLista;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                conexao.FecharBanco();
            }

        }

        public DataTable ListarTodosProdutos()
        {
            cmd.CommandText = "select  p.idProduto, p.codBarras, p.nomeProduto, f.nomeFantasia, p.descricaoProduto,p.quantidadeEstoqueProduto, p.precoCusto, p.margemLucro, p.precoVenda, p.dataFabricacao, p.dataVencimento, p.categoria, p.statusAtivo  From Produto p join Fornecedor f on p.codFornecedor = f.idFornecedor ";
            try
            {
                cmd.Connection = conexao.AbrirBanco();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtLista = new DataTable();
                da.Fill(dtLista);
                return dtLista;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                conexao.FecharBanco();
            }
        }
        public bool VerificarCodBarras()
        {


            cmd.CommandText = "select Count(1) from produto where codBarras= @codBarras ";
            cmd.Parameters.AddWithValue("@codBarras", produto.CodBarras);

            try
            {
                cmd.Connection = conexao.AbrirBanco();

                var resultado = cmd.ExecuteScalar();
                if (resultado.ToString() != "0")
                {
                    return true;
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                cmd.Parameters.Clear();
                conexao.FecharBanco();
            }


        }



    }
}
