using System.Net;

namespace ConsoleApp39
{    
    abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }


        // Abstract Method to CalculateSalary
        public abstract double CalculateSalary();

        // Concrete method to display employee details
        public void DisplayEmployee()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}, Name: {Name}, Salary: INR.{CalculateSalary()}");
        }

    }


    class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public FullTimeEmployee(int id, string name, double salary)
        {
            EmployeeId = id;
            Name = name;
            MonthlySalary = salary;
        }

        // Implementing abstract method
        public override double CalculateSalary()
        {
            // Additional Logic to process Salary
            return MonthlySalary; // Fixed monthly salary
        }
    }


    class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(int employeeId, string name, double hourlyRate, int hoursWorked)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
            EmployeeId = employeeId;
            Name = name;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }

     internal class Program
    {
        static void Main(string[] args)
        {

            // Creating Full-time employee
            FullTimeEmployee emp1 = new FullTimeEmployee(101, "Scott", 50000);


            // Creating Part-time employee
            PartTimeEmployee emp2 = new PartTimeEmployee(102, "Smith", 2000, 80); // 2000 per hour, 80 hours worked


            emp1.DisplayEmployee();
            emp2.DisplayEmployee();
             

            Console.ReadLine();
        }
    }
}
