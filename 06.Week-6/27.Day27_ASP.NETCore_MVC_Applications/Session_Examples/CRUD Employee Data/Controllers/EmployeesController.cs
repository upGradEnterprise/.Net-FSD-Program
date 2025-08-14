using Microsoft.AspNetCore.Mvc;
using WebApplication50.Models;

namespace WebApplication50.Controllers
{
    public class EmployeesController : Controller
    {
        public static List<Employee> employees = new List<Employee>
                {
                    new Employee { Id = 1, Name = "Alice", Job = "Manager", Salary = 75000, Deptno = 10 },
                    new Employee { Id = 2, Name = "Bob", Job = "Developer", Salary = 65000, Deptno = 20 },
                    new Employee { Id = 3, Name = "Charlie", Job = "Analyst", Salary = 60000, Deptno = 20 },
                    new Employee { Id = 4, Name = "Diana", Job = "HR", Salary = 55000, Deptno = 30 },
                    new Employee { Id = 5, Name = "Ethan", Job = "Support", Salary = 45000, Deptno = 40 }
                    };

        public IActionResult Index()
        {
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            var emp = employees.FirstOrDefault(x => x.Id == id);
            return View(emp);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            employees.Add(emp);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = employees.FirstOrDefault(x => x.Id == id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            var existEmp = employees.FirstOrDefault( x => x.Id == emp.Id);

            existEmp.Name = emp.Name;
            existEmp.Salary= emp.Salary;
            existEmp.Job = emp.Job;
            existEmp.Deptno = emp.Deptno;


            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var emp = employees.FirstOrDefault(x => x.Id == id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var emp = employees.FirstOrDefault(x => x.Id == id);
            employees.Remove(emp);
            return RedirectToAction("Index");
        }



    }
}
