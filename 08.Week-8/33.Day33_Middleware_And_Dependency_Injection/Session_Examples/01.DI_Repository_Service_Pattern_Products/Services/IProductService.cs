using WebApplication51.Models;

namespace WebApplication51.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
    }
}
