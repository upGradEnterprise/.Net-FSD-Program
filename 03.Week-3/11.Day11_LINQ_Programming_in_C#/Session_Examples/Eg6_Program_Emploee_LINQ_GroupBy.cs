using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

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


            var groupByDept = from emp in employees
                              group emp by emp.Department;


            foreach(var groupItem in groupByDept)
            {
                Console.WriteLine($"Department : {groupItem.Key}");

                foreach (var item in groupItem)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-------------------------");
            }


            var groupByDeptStatusQuery = from emp in employees
                                         group emp by emp.Department into g
                                         select new {
                                            Department = g.Key,
                                            EmployeeCount = g.Count(),
                                            AvgSalary = g.Average(x => x.Salary)
                                         };


            foreach (var item in groupByDeptStatusQuery)
            {
                Console.WriteLine($"Department = {item.Department}, Employee Count = {item.EmployeeCount}, AvgSalary={item.AvgSalary:F2}");
            }



            Console.ReadLine();
        }
    }

}
