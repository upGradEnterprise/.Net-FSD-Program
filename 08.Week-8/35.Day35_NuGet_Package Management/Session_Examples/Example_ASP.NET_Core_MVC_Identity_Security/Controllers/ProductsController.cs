using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{

    [Authorize]
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product> {
                new Product(){ Id=1, Name="Laptop-1", Price=65000, Category="Electronics" },
                new Product(){ Id=2, Name="Laptop-2", Price=65000, Category="Electronics" },
                new Product(){ Id=3, Name="Laptop-3", Price=65000, Category="Electronics" },
                new Product(){ Id=4, Name="Laptop-4", Price=65000, Category="Electronics" },
                new Product(){ Id=5, Name="Laptop-5", Price=65000, Category="Electronics" },
            };

            return View(products);
        }
    }
}
