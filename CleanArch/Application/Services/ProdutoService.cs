using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Produto> ObterPorCodigo(string codigo)
        {
            return await _repository.GetByCodigoBarrasAsync(codigo);
        }
    }
}
