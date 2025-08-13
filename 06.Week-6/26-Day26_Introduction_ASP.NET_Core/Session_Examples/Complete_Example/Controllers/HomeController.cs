using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication49.Models;

namespace WebApplication49.Controllers
{
    public class HomeController : Controller
    {     

        public IActionResult Index()
        {           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {   
                return View(); 
        }
    }
}
