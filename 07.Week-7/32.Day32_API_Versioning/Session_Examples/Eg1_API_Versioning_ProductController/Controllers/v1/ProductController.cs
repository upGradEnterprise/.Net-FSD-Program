using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
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
            return Ok(products);
        }


    }
}
