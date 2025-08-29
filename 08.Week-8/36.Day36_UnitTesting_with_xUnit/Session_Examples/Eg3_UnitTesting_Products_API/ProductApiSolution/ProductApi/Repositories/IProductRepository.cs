using ProductApi.Models;
using System.Threading.Tasks;

namespace ProductApi.Repositories;

public interface IProductRepository
{
    Task<Product> GetByIdAsync(int id);
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product> AddAsync(Product product);
    Task<Product> UpdateAsync(Product product);
    Task<bool> DeleteAsync(int id);
}