using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeesController : Controller
    {

        private readonly Sept2024DbContext _context;

        public EmployeesController(Sept2024DbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var emps = _context.Emps.ToList();
            return View(emps);
        }

        public IActionResult Index2()
        {
            var emps = _context.Emps.Include(e => e.Dept).ToList();
            return View(emps);
        }

        public IActionResult Depts()
        {
            var depts = _context.Depts.Include(d => d.Emps).ToList();
            return View(depts);
        }

        public IActionResult EmpsDepts()
        {
            EmpsDeptsVM  empsDeptsVM = new EmpsDeptsVM();

            empsDeptsVM.Emps = _context.Emps.ToList();
            empsDeptsVM.Depts  = _context.Depts.ToList();
            
            return View(empsDeptsVM);
        }



    }
}
