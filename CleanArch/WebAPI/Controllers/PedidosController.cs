using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using CleanArch.Domain.Entities;
using CleanArch.Application.Services;

namespace CleanArch.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly PedidoService _pedidoService;

        public PedidosController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pedido pedido)
        {
            await _pedidoService.CriarNovoPedido(pedido);
            return Ok(new { message = "Pedido enviado ao RabbitMQ e salvo no Postgres!" });
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pedidos = await _pedidoService.ObterTodosPedidos();
            return Ok(pedidos);
        }
    }
}
