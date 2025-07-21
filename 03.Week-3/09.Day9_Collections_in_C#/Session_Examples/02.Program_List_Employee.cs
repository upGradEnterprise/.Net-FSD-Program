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

            List<Employee> empList = new List<Employee>();

            Employee e1 = new Employee() { Id = 1, Name = "Alice", Job = "Manager", Salary = 75000, Deptno = 10 };
            Employee e2 = new Employee() { Id = 2, Name = "Bob", Job = "Developer", Salary = 65000, Deptno = 20 };
            Employee e3 = new Employee() { Id = 3, Name = "Charlie", Job = "Analyst", Salary = 60000, Deptno = 20 };

            empList.Add( e1  );
            empList.Add( e2  );
            empList.Add( e3  );

            // Iteration
            foreach (Employee item in empList)
            {
                Console.WriteLine(item);
            }
          

            Console.ReadLine();
        }
    }
}
