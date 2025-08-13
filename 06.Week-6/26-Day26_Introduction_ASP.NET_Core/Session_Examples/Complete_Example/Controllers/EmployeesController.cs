using Microsoft.AspNetCore.Mvc;
using WebApplication49.Models;

namespace WebApplication49.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>
            {
                    new Employee { Id = 1, Name = "Alice", Job = "Manager", Salary = 75000, Deptno = 10 },
                    new Employee { Id = 2, Name = "Bob", Job = "Developer", Salary = 65000, Deptno = 20 },
                    new Employee { Id = 3, Name = "Charlie", Job = "Analyst", Salary = 60000, Deptno = 20 },
                    new Employee { Id = 4, Name = "Diana", Job = "HR", Salary = 55000, Deptno = 30 },
                    new Employee { Id = 5, Name = "Ethan", Job = "Support", Salary = 45000, Deptno = 40 }
            };

            return View(employees);
        }

        public IActionResult EmployeeDetails()
        {
            var employee = new Employee() { Id = 1, Name = "Scott", Job = "Manager", Salary = 50000, Deptno = 10 };

            return View(employee);
        }




    }
}
