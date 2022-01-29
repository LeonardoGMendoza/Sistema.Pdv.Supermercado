
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SistemaPDVBack.Model
{


    class Conexao
    {

        SqlConnection con = new SqlConnection();

        private  string conexao = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Conexao()
        {
            con.ConnectionString = conexao;
        }
        public SqlConnection AbrirBanco()
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
        public void FecharBanco()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }



        }
    }
}
