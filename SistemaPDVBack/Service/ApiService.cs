using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPDVBack.Service
{
    public class ApiService
    {
        private static readonly HttpClient client = new HttpClient();
        private const string API_URL = "https://pdv.sandlj.com.br/api/Pedidos";

        public async Task EnviarPedidoAsync(object pedido)
        {
            try
            {
                // Como não temos Newtonsoft.Json fácil, vamos montar um JSON simples
                // para o objeto de teste. Para um sistema real, o ideal é usar uma lib.
                
                string json = SerializePedido(pedido);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(API_URL, content);
                
                if (!response.IsSuccessStatusCode)
                {
                    // Log ou erro se necessário
                }
            }
            catch (Exception ex)
            {
                // Previne travar o PDV se a internet cair
            }
        }

        private string SerializePedido(dynamic p)
        {
            // Versão ultra-compatível com String.Format para evitar erros de chaves
            return string.Format("{{ \"colaboradorId\": {0}, \"clienteId\": {1}, \"status\": {2}, \"dataPedido\": \"{3:yyyy-MM-ddTHH:mm:ss}Z\", \"formaPagamento\": \"{4}\", \"total\": {5} }}",
                p.ColaboradorId, 
                p.ClienteId, 
                p.Status, 
                DateTime.Now, 
                p.FormaPagamento, 
                p.Total.ToString().Replace(",", "."));
        }
    }
}
