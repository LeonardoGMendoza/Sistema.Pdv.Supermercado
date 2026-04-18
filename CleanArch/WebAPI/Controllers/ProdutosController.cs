using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArch.Domain.Entities;
using CleanArch.Application.Services;

namespace CleanArch.WebAPI.Controllers
{
    [ApiController]
    [Route("api/produtos")]
    public class ProdutosController : ControllerBase
    {
        private readonly ProdutoService _produtoService;

        public ProdutosController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var produtos = await _produtoService.ObterTodos();
            return Ok(produtos);
        }

        [HttpGet("{codigo}")]
        public async Task<IActionResult> GetByCodigo(string codigo)
        {
            var produto = await _produtoService.ObterPorCodigo(codigo);
            if (produto == null) return NotFound();
            return Ok(produto);
        }
    }
}
