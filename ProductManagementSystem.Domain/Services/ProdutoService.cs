using ProductManagementSystem.Domain.Entities;
using ProductManagementSystem.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IEnumerable<Produto>> GetAllAsync()
        {
            return await _produtoRepository.GetAllAsync();
        }

        public async Task<Produto> GetByIdAsync(int id)
        {
            return await _produtoRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Produto produto)
        {
            await _produtoRepository.AddAsync(produto);
        }

        public async Task UpdateAsync(Produto produto)
        {
            var produtoExistente = await _produtoRepository.GetByIdAsync(produto.Id);
            if (produtoExistente != null)
            {
                produtoExistente.AtualizarProduto(produto.Nome, produto.PrecoBase);

                produtoExistente.Variacoes?.Clear();

                if (produto.Variacoes != null && produto.Variacoes.Any())
                {
                    produtoExistente.Variacoes = produto.Variacoes.Select(v =>
                        new Variacao(v.NomeVariacao) { ProdutoId = produtoExistente.Id }
                    ).ToList();
                }
                await _produtoRepository.UpdateAsync(produtoExistente);
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _produtoRepository.DeleteAsync(id);
        }
    }
}
