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
            // Serialização manual ultra-rápida (para evitar dependências no legatário)
            return $"{{\"colaboradorId\": {p.ColaboradorId}, \"clienteId\": {p.ClienteId}, \"status\": {p.Status}, \"dataPedido\": \"{DateTime.Now:yyyy-MM-ddTHH:mm:ss}Z\", \"formaPagamento\": \"{p.FormaPagamento}\", \"total\": {p.Total.ToString().Replace(",", ".")}} }";
        }
    }
}
