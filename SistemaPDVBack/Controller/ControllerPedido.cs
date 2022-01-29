using System.Data.SqlClient;
using SistemaPDVBack.Model;
using SistemaPDVBack.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace SistemaPDVBack.Controller
{
    class ControllerPedido
    {

        SqlCommand cmd = new SqlCommand();
        Pedido pedido = new Pedido();
        Conexao conexao = new Conexao();
        private SqlDataReader reader;
        List<ProdutoPedidoDTO> produtos = new List<ProdutoPedidoDTO>();

        public List<string> Layout = new List<string>();

        public ControllerPedido(string status, string dataDoPedido, string total, string formaPagamento)
        {
            ConverterValidar(status, dataDoPedido, total, formaPagamento);
        }
  

        private void ConverterValidar(string status, string dataDoPedido, string total, string formaPagamento)
        {
            try
            {
                pedido.Status = int.Parse(status);
                pedido.DataDoPedido = dataDoPedido;
                pedido.IdColaborador = CarregaUsuario.IdUser;
                pedido.TotalPedido = decimal.Parse(total);
                pedido.FormaDePagamento = formaPagamento;


            }
            catch (Exception e)
            {
                throw;
            }

        }

        public ControllerPedido()
        {
            CarregaPedido();

        }


        public void AdicionarPedido()
        {


            cmd.CommandText = "insert into Pedido(idColaborador,status, dataDoPedido,codCliente, formaPagamento, totalPedido) values(@idColaborador,@status,@dataDoPedido,@codCliente,  @formaPagamento, @totalPedido)";

            cmd.Parameters.AddWithValue("@idColaborador", pedido.IdColaborador);
            if (!pedido.CodCliente.Equals(null))
            {
                cmd.Parameters.AddWithValue("@codCliente", pedido.CodCliente);

            }
            else
            {
                cmd.Parameters.AddWithValue("@codCliente", pedido.CodCliente);

            }
            cmd.Parameters.AddWithValue("@status", pedido.Status);
            cmd.Parameters.AddWithValue("@dataDoPedido", pedido.DataDoPedido);
            cmd.Parameters.AddWithValue("@formaPagamento", pedido.FormaDePagamento);
            cmd.Parameters.AddWithValue("@totalPedido", pedido.TotalPedido);

                      
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

        public void CarregaCpf()
        {


            cmd.CommandText = "select idCliente from Cliente where idCliente= (select max(idCliente) from Cliente)";
            try
            {
                cmd.Connection = conexao.AbrirBanco();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        pedido.CodCliente = reader.GetInt32(0);
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


        
        private void CarregaPedido()
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

                        pedido.IdPedido = reader.GetInt32(0);
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
      
        public string VerificarCaixa()
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\leonardo\\source\\repos\\Sistema.Pdv.Supermercado-Back-bdd22947f3ff6397bfc81a167038b333e1d9cd3d\\Caixa.txt"))
            {
                string Caixa = "";

                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Caixa = line;
                }

                return Caixa;
            }
        }

        public void ImprimirCupom(string codItem, string codigoBarras, string Descricao, string quantidade, string valorUnitario,
            string total, string Status, string cpf, string data, string hora, string caixa, string formaPagamento, string valorRecebido,
            string troco, string totalVendido)
        {
            var novaDescricao = "";

            if(Descricao.Length >= 20)
            {

                 novaDescricao = Descricao.Substring(0, 20);

            }
            else
            {
                novaDescricao = Descricao;
            }


            produtos.Add(new ProdutoPedidoDTO(codItem, codigoBarras, novaDescricao, quantidade, valorUnitario, total, Status));

            StreamWriter x;

            string path = "C:\\Recibos\\";
            Directory.CreateDirectory(path);

            string caminho =  path + pedido.IdPedido + ".txt";

            x = File.CreateText(caminho);

            foreach (ProdutoPedidoDTO obj in produtos)
            {

                x.WriteLine(obj.CodigoItem + ";" + obj.CodBarras + ";" + obj.NomeProduto + ";" + obj.Quantidade + ";" + obj.PrecoUnit + ";" + obj.Total + ";" + obj.StatusAtivo + ";");
            }
            x.WriteLine("" + ";" + "" + ";" + "Total R$" + ";" + "" + ";" + "" + ";" + totalVendido + ";" + "" + ";");
            x.WriteLine("" + ";" + "" + ";" + formaPagamento + ";" + "" + ";" + "" + ";" + valorRecebido + ";" + "" + ";");
            if(troco != "0,00")
            {
                x.WriteLine("" + ";" + "" + ";" + "Troco" + ";" + "" + ";" + "" + ";" + troco + ";" + "" + ";");

            }

            x.Close();

            StringBuilder sb = new StringBuilder();

            string caminhoArquivo = path + pedido.IdPedido + ".txt";

            var consulta = from linha in File.ReadAllLines(caminhoArquivo)
                           let ProdutoDados = linha.Split(';')
                           select new ProdutoPedidoDTO()
                           {
                               CodigoItem = ProdutoDados[0],
                               CodBarras = ProdutoDados[1],
                               NomeProduto = ProdutoDados[2],
                               Quantidade = ProdutoDados[3],
                               PrecoUnit = ProdutoDados[4],
                               Total = ProdutoDados[5],
                               StatusAtivo = ProdutoDados[6],
                           };


            foreach (var item in consulta)
            {
                sb.AppendFormat("{0,-3}{1,-15}{2,-23}{3,-4}{4,-7}{5,-28}{6,-30}{7}",
                   item.CodigoItem,
                   item.CodBarras,
                   item.NomeProduto,
                   item.Quantidade,
                   item.PrecoUnit,
                   item.Total,
                   item.StatusAtivo,

                   Environment.NewLine);
            }
            File.WriteAllText(path + pedido.IdPedido + ".txt", sb.ToString());

            Layout.Clear();

            using (StreamReader reader = new StreamReader(path + pedido.IdPedido + ".txt"))
            {
                Layout.Add("");
                Layout.Add(" LUCAS GABRIEL SOUZA SILVA - LTDA ");
                Layout.Add(" Rua Orelio Sabadin n° 210");
                Layout.Add(" Sorocaba-Sp");
                Layout.Add(" -----------------------------------------------------------");
                Layout.Add(" CNPJ: 71.564.173/0001-80                         " + data);
                Layout.Add(" IE: 714.145.789                                  " + hora);
                Layout.Add(" IM: 4567412                     ");
                Layout.Add(" -----------------------------------------------------------");
                Layout.Add(" CODIGO:" + pedido.IdPedido);

                Layout.Add(" CPF/CNPJ:" + cpf);

                Layout.Add(" -----------------------------------------------------------");
                Layout.Add(" ------------------------CUPOM FISCAL-----------------------");
                Layout.Add(" -----------------------------------------------------------");

                Layout.Add("COD CDB            DESC.                 QTDE   UN   VALOR");

                Layout.Add("");


                List<string> Todos = new List<string>();
                List<string> cancelado = new List<string>();
                List<string> totalVenda = new List<string>();

                string line;
                

                while ((line = reader.ReadLine()) != null)
                {


                    if (line.Contains("Cancelado"))
                    {
                        string linhaAlterada;
                        linhaAlterada = line.Replace("Cancelado", "");
                        cancelado.Add(linhaAlterada);
                        Todos.Add(linhaAlterada);
                    }
                    else if (line.Contains("Total"))
                    {
                        totalVenda.Add(line);
                    }
                    else if (line.Contains(formaPagamento))
                    {
                        totalVenda.Add(line);
                    }
                    else if (line.Contains("Troco"))
                    {
                        totalVenda.Add(line);

                    }
                    else
                    {
                        string linhaAlterada;
                        linhaAlterada = line.Replace("Cancelado", "").Replace("Ativo","");
                        Todos.Add(linhaAlterada);
                    }
                }



                foreach (string obj in Todos)
                {
                    Layout.Add(" " + obj);
                }
                bool vericadora = false;


                foreach (string obj in cancelado)
                {
                    if (vericadora == false)
                    {
                        Layout.Add(" -----------------------------------------------------------");
                        Layout.Add(" ------------------------CANCELADO--------------------------");
                        Layout.Add(" -----------------------------------------------------------");
                        vericadora = true;

                    }
                    Layout.Add(" " + obj);



                }
                Layout.Add(" -----------------------------------------------------------");



                foreach (string obj in totalVenda)
                {
                    Layout.Add(" " + obj);
                }


                Layout.Add(" -----------------------------------------------------------");
                Layout.Add(" -----------------------------------------------------------");

                Layout.Add(" CAIXA:" + caixa);
                Layout.Add(" COLABORAR:" + CarregaUsuario.Nome);
                Layout.Add(" PDVR 2.0.3");
                Layout.Add(" BEMATECH MP -2100");
                Layout.Add(" -----------------------------------------------------------");


            }
            x = File.CreateText(caminho);


            foreach (string obj in Layout)
            {

                x.WriteLine(obj);


            }

            x.Close();

        }

      




    }
}
