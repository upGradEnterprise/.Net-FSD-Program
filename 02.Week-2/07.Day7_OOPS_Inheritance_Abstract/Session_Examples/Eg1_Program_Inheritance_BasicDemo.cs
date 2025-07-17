namespace ConsoleApp39
{

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string Job { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
          
            Employee employee = new Employee();
            employee.EmployeeId = 6445454;
            employee.Name = "Narasimha Rao";
            employee.Age = 32;
            employee.Job = "Manager";


            Console.WriteLine($" {employee.EmployeeId},  {employee.Name}, {employee.Job}, {employee.Age}");

            Console.ReadLine();
        }
    }
}
