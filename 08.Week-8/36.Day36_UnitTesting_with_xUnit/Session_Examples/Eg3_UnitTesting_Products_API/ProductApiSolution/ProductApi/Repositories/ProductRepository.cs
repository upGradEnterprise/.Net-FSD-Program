using Microsoft.EntityFrameworkCore;
using ProductApi.Data;
using ProductApi.Models;
using System.Threading.Tasks;

namespace ProductApi.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product> AddAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<Product> UpdateAsync(Product product)
    {
        var existing = await _context.Products.FindAsync(product.Id);
        if (existing == null)
            throw new KeyNotFoundException("Product not found.");
        existing.Name = product.Name;
        existing.Price = product.Price;
        existing.Category = product.Category;
        await _context.SaveChangesAsync();
        return existing;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
            return false;
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
        return true;
    }
}