using WebApplication51.Models;

namespace WebApplication51.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
    }
}
