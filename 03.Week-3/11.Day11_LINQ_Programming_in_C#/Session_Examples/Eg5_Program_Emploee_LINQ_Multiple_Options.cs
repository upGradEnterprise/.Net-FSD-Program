using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp39
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public int PerformanceScore { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Department}, {Salary}, {PerformanceScore}";
        }
    }

    public class Program
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Sarah", Department = "IT", Salary = 75000, PerformanceScore = 85 },
                new Employee { Id = 2, Name = "Mike", Department = "IT", Salary = 65000, PerformanceScore = 90 },
                new Employee { Id = 3, Name = "Lisa", Department = "IT", Salary = 80000, PerformanceScore = 88 },
                new Employee { Id = 4, Name = "Tom", Department = "Sales", Salary = 70000, PerformanceScore = 82 },
                new Employee { Id = 5, Name = "Bob", Department = "Sales", Salary = 60000, PerformanceScore = 72 },
                new Employee { Id = 6, Name = "Ralph", Department = "HR", Salary = 50000, PerformanceScore = 62 }
            };


            // LINQ Query Syntax :   IT department employees with high performance
            var highPerformersQuery = from emp in employees
                                      where emp.Department == "IT" && emp.PerformanceScore > 85
                                      orderby emp.Salary descending
                                      select new { emp.Name, emp.Salary, emp.PerformanceScore };
 
            // Method Syntax: Aggregates for IT department
            var itEmployees = employees.Where(e => e.Department == "IT");
            var avgSalary = itEmployees.Average(e => e.Salary);
            var maxScore = itEmployees.Max(e => e.PerformanceScore);


            Console.WriteLine("High Performing IT Employees (Score > 85):");
            foreach (var emp in highPerformersQuery)
            {
                Console.WriteLine($"Name: {emp.Name}, Salary: ${emp.Salary}, Score: {emp.PerformanceScore}");
            }
            Console.WriteLine($"Average IT Salary: ${avgSalary:F2}");
            Console.WriteLine($"Highest IT Performance Score: {maxScore}");

	
			List<Employee> result = itEmployees.ToList();


            Console.ReadLine();
        }
    }

}
