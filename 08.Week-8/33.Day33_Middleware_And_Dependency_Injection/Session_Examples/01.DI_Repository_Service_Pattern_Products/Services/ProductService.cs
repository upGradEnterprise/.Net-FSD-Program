using WebApplication51.Models;
using WebApplication51.Repositories;

namespace WebApplication51.Services
{
    public class ProductService : IProductService   
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;   
        }
        public IEnumerable<Product> GetProducts()
        {
            // add business logic if required
            return _repo.GetAll();
        }
        public Product GetProductById(int id)
        {
            return _repo.GetById(id);
        }
    }
}
