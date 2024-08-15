using ProductManagementSystem.Domain.Entities;
using ProductManagementSystem.Domain.Repositories;
using ProductManagementSystem.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

public class ProdutoRepository : IProdutoRepository
{
    private readonly ApplicationDbContext _context;

    public ProdutoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Produto>> GetAllAsync()
    {
        return await _context.Produtos.Include(p => p.Variacoes).ToListAsync();
    }

    public async Task<Produto> GetByIdAsync(int id)
    {
        return await _context.Produtos.Include(p => p.Variacoes).FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task AddAsync(Produto produto)
    {
        await _context.Produtos.AddAsync(produto);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Produto produto)
    {
        _context.Produtos.Update(produto);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);
        _context.Produtos.Remove(produto);
        await _context.SaveChangesAsync();
    }
}
