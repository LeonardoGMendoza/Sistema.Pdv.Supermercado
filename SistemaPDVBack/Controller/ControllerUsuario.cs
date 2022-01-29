using System.Data.SqlClient;
using SistemaPDVBack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPDVBack.Controller
{
    class ControllerUsuario
    {
        Usuario login = new Usuario();
        Colaborador colaborador = new Colaborador();
        Conexao conexao = new Conexao();
        private readonly SqlCommand cmd = new SqlCommand();
        private SqlDataReader reader;

        public ControllerUsuario(string usuario, string senha, string cpfColaborador, string statusAtivo, string id)
        {
            ValidarConverter(usuario, senha, cpfColaborador, statusAtivo, id);
            if (string.IsNullOrEmpty(id))
            {
                LerColaborador();
            }



        }
        public ControllerUsuario(string usuario, string senha)
        {

            login.Login = usuario;
            login.Senha = senha;

        }

        private void LerColaborador()
        {
            cmd.CommandText = "select *from Colaborador where cpfColaborador = @cpfColaborador ";
            cmd.Parameters.AddWithValue("@cpfColaborador", colaborador.CpfColaborador);

            try
            {
                cmd.Connection = conexao.AbrirBanco();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        colaborador.IdColaborador = reader.GetInt32(0);

                    }

                }
                else
                {

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                conexao.FecharBanco();
            }
        }
        private void ValidarConverter(string usuario, string senha, string cpf, string statusAtivo, string id)
        {
            try
            {

                if (!string.IsNullOrEmpty(id))
                {
                    colaborador.IdColaborador = int.Parse(id);
                }

                login.StatusAtivo = Convert.ToBoolean(statusAtivo);
                login.Login = usuario;
                login.Senha = senha;
                colaborador.CpfColaborador = cpf;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        public bool Login()
        {
            cmd.CommandText = "select * from usuario where login = @login and senha = @senha and statusAtivo = 1";
            cmd.Parameters.AddWithValue("@login", login.Login);
            cmd.Parameters.AddWithValue("@senha", login.Senha);
            try
            {
                cmd.Connection = conexao.AbrirBanco();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CarregaUsuario.Nome = reader["Login"].ToString();
                        CarregaUsuario.IdUser = int.Parse(reader["IdUser"].ToString());
                    }
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                conexao.FecharBanco();
                cmd.Parameters.Clear();

            }

        }

        public void AdicionarUsuario()
        {
            cmd.CommandText = "insert into Usuario(idColaborador, usuario, senha, statusAtivo) values (@idColaborador, @usuario, @senha, @statusAtivo) ";

            cmd.Parameters.AddWithValue("@idColaborador", colaborador.IdColaborador);
            cmd.Parameters.AddWithValue("@usuario", login.Login);
            cmd.Parameters.AddWithValue("@senha", login.Senha);
            cmd.Parameters.AddWithValue("@statusAtivo", login.StatusAtivo);
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

        public void AlterarUsuario()
        {
            try
            {



                cmd.CommandText = "Update Usuario set usuario = @usuario, senha = @senha, statusAtivo = @statusAtivo where idColaborador = @idColaborador";
                cmd.Parameters.AddWithValue("@usuario", login.Login);
                cmd.Parameters.AddWithValue("@senha", login.Senha);
                cmd.Parameters.AddWithValue("@statusAtivo", login.StatusAtivo);

                cmd.Parameters.AddWithValue("@idColaborador", colaborador.IdColaborador);

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

        string cargo = "";

        public string VerificaCargo()
        {
            try
            {
                cmd.CommandText = "Select *from colaborador where idColaborador = @idColaborador";
                cmd.Parameters.AddWithValue("@idColaborador", CarregaUsuario.IdUser);
                cmd.Connection = conexao.AbrirBanco();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cargo = reader.GetString(4);
                    }
                }
                return cargo;

            }
            catch (Exception)
            {
                return cargo = "Não encontrado";
            }
            finally
            {
                cmd.Parameters.Clear();
                conexao.FecharBanco();
            }
        }



    }
}
