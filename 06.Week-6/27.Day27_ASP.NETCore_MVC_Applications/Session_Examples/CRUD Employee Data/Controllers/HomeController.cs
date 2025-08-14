using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication50.Models;

namespace WebApplication50.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin123")
            {
                // ViewBag.Message = "Welcome to Admin";
                TempData["uname"] = username;
               return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid User Id or Password";
                return View();
            }          
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
