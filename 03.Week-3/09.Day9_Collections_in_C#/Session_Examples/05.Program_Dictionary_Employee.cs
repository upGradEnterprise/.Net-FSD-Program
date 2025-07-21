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

                Dictionary<int, Employee> empsDictionary = new Dictionary<int, Employee>() {

                    { 101, new Employee() { Id = 101, Name = "Alice", Job = "Manager", Salary = 75000, Deptno = 10 } }, 
                    { 102, new Employee() { Id = 102, Name = "Bob", Job = "Developer", Salary = 65000, Deptno = 20 } }, 
                    { 103, new Employee() { Id = 103, Name = "Charlie", Job = "Analyst", Salary = 60000, Deptno = 20 } }
                };


             // Iterate all items based on Key
            foreach(var key in empsDictionary.Keys)
            {
                Console.WriteLine(empsDictionary[key]);
            }
            Console.WriteLine("----------------------");

            // Add a new employee
            empsDictionary.Add(104, new Employee { Id = 104, Name = "David", Job="Lead", Salary = 70000, Deptno=20 });



            foreach (var item in empsDictionary)
            {
                Console.WriteLine($"Key : {item.Key}, Value : {item.Value}");
            }

            Console.WriteLine("--------------------------------");


            Console.WriteLine("Enter Emp Id to remove : ");
            int eno = int.Parse(Console.ReadLine());

            if(empsDictionary.ContainsKey(eno))
            {
                // Remove an employee 
                empsDictionary.Remove(eno);
               
                foreach (var key in empsDictionary.Keys)
                {
                    Console.WriteLine(empsDictionary[key]);
                }
            }
            else
            {
                Console.WriteLine("Emp Id does not exists.");
            }
            


            Console.ReadLine();
            }
        }    
}
