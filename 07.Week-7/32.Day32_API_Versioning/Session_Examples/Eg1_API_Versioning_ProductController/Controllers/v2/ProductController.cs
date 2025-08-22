using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers.v2
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2.0")]
    public class ProductController : ControllerBase
    {
        List<Product> products = new List<Product> {
                new Product(){ Id=1, Name="Laptop-1", Price=65000, Category="Electronics" },
                new Product(){ Id=2, Name="Laptop-2", Price=65000, Category="Electronics" },
                new Product(){ Id=3, Name="Laptop-3", Price=65000, Category="Electronics" },
                new Product(){ Id=4, Name="Laptop-4", Price=65000, Category="Electronics" },
                new Product(){ Id=5, Name="Laptop-5", Price=65000, Category="Electronics" },
            };


        [HttpGet]
        public IActionResult GetProducts()
        {
            products.Add(new Product() { Id = 6, Name = "Laptop-6", Price = 65000, Category = "Electronics" });
            products.Add(new Product() { Id = 7, Name = "Laptop-7", Price = 65000, Category = "Electronics" });
            return Ok(products); 
        }


    }
}
