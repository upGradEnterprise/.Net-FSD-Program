using Microsoft.AspNetCore.Mvc;
using WebApplication51.Models;

namespace WebApplication51.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context) {
                _context = context;
        }


        public IActionResult Index()
        {           
            var products = _context.Products.ToList();
            return View( products  );
        }

         
        public IActionResult Details(int id)
        {
            var product = _context.Products.Find(id);   //  Applicable for only primary key property
            return View(product);
        }


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


    }
}
