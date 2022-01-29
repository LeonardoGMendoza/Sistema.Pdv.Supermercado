using System.Data.SqlClient;
using SistemaPDVBack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Controller
{
    class ControllerCliente
    {
        SqlCommand cmd = new SqlCommand();
        Cliente cli = new Cliente();
        Conexao conexao = new Conexao();
        public ControllerCliente(string cpfCnpj)
        {
            cli.CpfCnpj = cpfCnpj;

            if (cpfCnpj.Length <= 14)
            {
                cli.TipoCliente = "Física";
            }
            else
            {
                cli.TipoCliente = "Jurídica";
            }
        }
        public void AdicionarCliente()
        {
            cmd.CommandText = "Insert into Cliente(Cpf_Cnpj,tipoCliente) values (@Cpf_Cnpj, @tipoCliente)";
            cmd.Parameters.AddWithValue("@Cpf_Cnpj", cli.CpfCnpj);
            cmd.Parameters.AddWithValue("@tipoCliente", cli.TipoCliente);

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


}
