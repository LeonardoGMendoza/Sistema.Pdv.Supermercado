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
    class ControllerFornecedor
    {
        private readonly SqlCommand cmd = new SqlCommand();
        private readonly string _inserir = "insert into Fornecedor(Cnpj,nomeFantasia, inscricaoEstadual, cepFornecedor, Rua,  uf, numero, complemento,bairro, cidade, statusAtivo ) " +
                                            "values(@cnpj,@nomeFantasia,  @inscricaoEstadual, @cepFornecedor,@rua, @uf, @numero, @complemento, @bairro, @cidade, @statusAtivo)";
        private readonly string _alterar = "update Fornecedor set   cnpj = @cnpj ,nomeFantasia = @nomeFantasia, inscricaoEstadual = @inscricaoEstadual, uf = @uf , numero = @numero, complemento = @complemento, bairro = @bairro,cidade = @cidade, cepFornecedor = @cepFornecedor, statusAtivo = @statusAtivo, rua = @rua where idFornecedor = @idFornecedor  ";
        private readonly string _listar = "select *from Fornecedor where statusAtivo = 1 ";


        Fornecedor fornecedor = new Fornecedor();
        Conexao conexao = new Conexao();
        string mensagem = "";
        public string Ds_Msg
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public ControllerFornecedor()
        {

        }
        public ControllerFornecedor(string nome)
        {
            fornecedor.NomeFantasia = nome;
        }
        public ControllerFornecedor(string idFornecedor, string inscricaoEstadual, string nomeFantasia, string uf, string numero, string complemento, string bairro, string cidade,
                                    string cep, string statusAtivo, string rua, string cnpj)
        {
            ConverterValidar(idFornecedor, inscricaoEstadual, nomeFantasia, uf, numero, complemento, bairro, cidade, cep, statusAtivo, rua, cnpj);
        }

        private void ConverterValidar(string idFornecedor, string inscricaoEstadual, string nomeFantasia, string uf, string numero, string complemento, string bairro, string cidade, string cep, string statusAtivo, string rua, string cnpj)
        {
            if (mensagem == "")
            {


                try
                {

                    if (idFornecedor != "")
                    {
                        fornecedor.IdFornecedor = int.Parse(idFornecedor);

                    }
                    if (rua != "" && nomeFantasia != "" && bairro != "" && cidade != "" && uf != "")
                    {
                        string temp;
                        fornecedor.Rua = rua;
                        fornecedor.NomeFantasia = nomeFantasia;
                        fornecedor.NumeroPessoa = numero;
                        fornecedor.BairroPessoa = bairro;
                        fornecedor.CidadePessoa = cidade;
                        temp = uf.Replace(" ", "");
                        fornecedor.UfPessoa = temp;
                    }
                    else
                    {
                    }
                    string inscricao = inscricaoEstadual.Replace(".", "");
                    fornecedor.Cnpj = cnpj;
                    fornecedor.StatusAtivo = int.Parse(statusAtivo);
                

                    if (inscricao.Length > 12)
                    {
                        mensagem = "campo invalido ";


                    }
                    else
                    {
                        fornecedor.InscricaoEstadual = inscricao;
                    }
                    fornecedor.ComplementoPessoa = complemento;
                    string cepFornecedor = cep.Replace(".", "").Replace("-", "");
                    fornecedor.CepFornecedor = int.Parse(cepFornecedor);
                }
                catch (Exception e)
                {
                    mensagem = e.Message;
                }
            }


        }

        public void AdicionarFornecedor()
        {
            if (mensagem == "")
            {
                cmd.CommandText = _inserir;

                cmd.Parameters.AddWithValue("@inscricaoEstadual", fornecedor.InscricaoEstadual);
                cmd.Parameters.AddWithValue("@statusAtivo", fornecedor.StatusAtivo);
                cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                cmd.Parameters.AddWithValue("@rua", fornecedor.Rua);
                cmd.Parameters.AddWithValue("@nomeFantasia", fornecedor.NomeFantasia);
                cmd.Parameters.AddWithValue("@uf", fornecedor.UfPessoa);
                cmd.Parameters.AddWithValue("@numero", fornecedor.NumeroPessoa);
                cmd.Parameters.AddWithValue("@complemento", fornecedor.ComplementoPessoa);
                cmd.Parameters.AddWithValue("@bairro", fornecedor.BairroPessoa);
                cmd.Parameters.AddWithValue("@cidade", fornecedor.CidadePessoa);
                cmd.Parameters.AddWithValue("@cepFornecedor", fornecedor.CepFornecedor);

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


        public void AlterarFornecedor()
        {
            if (mensagem == "")
            {
                cmd.CommandText = _alterar;
                cmd.Parameters.AddWithValue("@idFornecedor", fornecedor.IdFornecedor);
                cmd.Parameters.AddWithValue("@inscricaoEstadual", fornecedor.InscricaoEstadual);
                cmd.Parameters.AddWithValue("@nomeFantasia", fornecedor.NomeFantasia);
                cmd.Parameters.AddWithValue("@uf", fornecedor.UfPessoa);
                cmd.Parameters.AddWithValue("@numero", fornecedor.NumeroPessoa);
                cmd.Parameters.AddWithValue("@complemento", fornecedor.ComplementoPessoa);
                cmd.Parameters.AddWithValue("@bairro", fornecedor.BairroPessoa);
                cmd.Parameters.AddWithValue("@cidade", fornecedor.CidadePessoa);
                cmd.Parameters.AddWithValue("@cepFornecedor", fornecedor.CepFornecedor);
                cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                cmd.Parameters.AddWithValue("@rua", fornecedor.Rua);
                cmd.Parameters.AddWithValue("@statusAtivo", fornecedor.StatusAtivo);


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
                    cmd.Parameters.Clear();
                    conexao.FecharBanco();
                }


            }

        }


        public DataTable ListarFornecedor()
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
                    throw;
                }
                finally
                {
                    conexao.FecharBanco();
                }
            
        }


        public DataTable PesquisaFornecedor()
        {
           
                try
                {
                    cmd.CommandText = "select *from Fornecedor where nomeFantasia LIKE'%' @nomeFantasia '%' order by nomeFantasia";
                    cmd.Parameters.AddWithValue("@nomeFantasia", fornecedor.NomeFantasia);
                    cmd.Connection = conexao.AbrirBanco();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtLista = new DataTable();
                    da.Fill(dtLista);
                    return dtLista;
                }
                catch (Exception e)
                {
                    throw;
                }
            

        }
        public DataTable ListarTodosFornecedores()
        {
            cmd.CommandText = "select *from Fornecedor";
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
                throw;
            }
            finally
            {
                conexao.FecharBanco();
            }

        }
        public bool VerificarCnpj()
        {

            cmd.CommandText = "select Count(1) from fornecedor where cnpj= @cnpj ";
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);

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
