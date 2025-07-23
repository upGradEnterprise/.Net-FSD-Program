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
                new Employee { Id = 2, Name = "Mike", Department = "HR", Salary = 65000, PerformanceScore = 90 },
                new Employee { Id = 3, Name = "Lisa", Department = "IT", Salary = 80000, PerformanceScore = 88 },
                new Employee { Id = 4, Name = "Tom", Department = "Sales", Salary = 70000, PerformanceScore = 82 },
                new Employee { Id = 5, Name = "Bob", Department = "Sales", Salary = 60000, PerformanceScore = 72 },
                new Employee { Id = 6, Name = "Ralph", Department = "HR", Salary = 50000, PerformanceScore = 62 }
            };



            var q1 = employees.OrderByDescending(emp => emp.Salary);

            var q2 = employees.Where(emp => emp.Department == "HR").Select(emp => emp.Name);


            foreach (var item in q2)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }

}
