using Microsoft.AspNetCore.Mvc;
using ProductManagementSystem.Domain.Entities;
using ProductManagementSystem.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> Get()
        {
            var produtos = await _produtoService.GetAllAsync();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> Get(int id)
        {
            var produto = await _produtoService.GetByIdAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Produto produto)
        {
            await _produtoService.AddAsync(produto);
            return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            await _produtoService.UpdateAsync(produto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _produtoService.DeleteAsync(id);
            return NoContent();
        }
    }
}
