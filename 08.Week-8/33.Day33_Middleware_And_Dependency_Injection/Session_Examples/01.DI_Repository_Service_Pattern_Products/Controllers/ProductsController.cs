using Microsoft.AspNetCore.Mvc;
using WebApplication51.Models;
using WebApplication51.Services;

namespace WebApplication51.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service) {
            _service = service;
        }


        public IActionResult Index()
        {           
            var products = _service.GetProducts();  
            return View( products  );
        }

         
        public IActionResult Details(int id)
        {
            var product = _service.GetProductById(id);   
            return View(product);
        }

        /*
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product  product)
        {
            if (ModelState.IsValid)
            {
                // add product to database 
                _context.Products.Add( product );
                _context.SaveChanges();

                return RedirectToAction("Index");   
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid Product details.";
                return View();
            }
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);   
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges(); 

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            return View(product);
        }


        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var product = _context.Products.Find(id);

            if(product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Requested product does not exists";
                return View();
            }         

           
        }

        */


    }
}
