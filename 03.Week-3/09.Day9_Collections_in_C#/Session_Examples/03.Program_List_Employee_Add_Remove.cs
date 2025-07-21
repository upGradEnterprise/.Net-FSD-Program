using System.Collections.Generic;
using System.Xml.Linq;

namespace ConsoleApp39
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public decimal Salary { get; set; }
        public int Deptno { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Job: {Job}, Salary: {Salary}, DeptNo: {Deptno}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Collection Initializer
            List<Employee> empList = new List<Employee>()
            {
                  new Employee() { Id = 101, Name = "Alice", Job = "Manager", Salary = 75000, Deptno = 10 },
                  new Employee() { Id = 102, Name = "Bob", Job = "Developer", Salary = 65000, Deptno = 20 },
                  new Employee() { Id = 103, Name = "Charlie", Job = "Analyst", Salary = 60000, Deptno = 20 }
            };

           

            // Iteration
            foreach (Employee item in empList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------------");

            int eno = 105;
            Employee obj = empList.FirstOrDefault( item => item.Id == eno );

            if(obj != null)
                empList.Remove(obj);
            else
                Console.WriteLine($"Employee Id : {eno} does not exists");

            // Iteration
            foreach (Employee item in empList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
