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

    class EmployeeManagement
    {
        public List<Employee>  Employees { get; set; }

        public EmployeeManagement()
        {
            Employees = new List<Employee>()
            {
                  new Employee() { Id = 101, Name = "Alice", Job = "Manager", Salary = 75000, Deptno = 10 },
                  new Employee() { Id = 102, Name = "Bob", Job = "Developer", Salary = 65000, Deptno = 20 },
                  new Employee() { Id = 103, Name = "Charlie", Job = "Analyst", Salary = 60000, Deptno = 20 }
            };
        }


        public void AddEmployee()
        {
            Employee emp = new Employee();

            Console.Write("Enter ID: ");
            emp.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter Job: ");
            emp.Job = Console.ReadLine();

            Console.Write("Enter Salary: ");
            emp.Salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter DeptNo: ");
            emp.Deptno = Convert.ToInt32(Console.ReadLine());

            Employees.Add(emp);
            Console.WriteLine("Employee added successfully!");
        }

        public void RemoveEmployee()
        {
            Console.WriteLine("Enter Emp Id to remove: ");
            int eno = int.Parse(Console.ReadLine());

            Employee obj = Employees.FirstOrDefault(item => item.Id == eno);

            if (obj != null)
            {
                Employees.Remove(obj);
                Console.WriteLine("Employee removed successfully!");
            }
            else
            {
                Console.WriteLine($"Employee Id : {eno} does not exists");
            }
        }

        public void ShowEmployees()
        {
            // Iteration
            foreach (Employee item in Employees)
            {
                Console.WriteLine(item);
            }
        }

        public void UpdateEmployee()
        {
            // Update Operation

            Console.WriteLine("Enter the employee Id you want to update:");
            int eId = int.Parse(Console.ReadLine());

            Employee obj2 = Employees.FirstOrDefault(item => item.Id == eId);

            if (obj2 != null)
            {
                Console.WriteLine("Enter new Name (leave blank to keep unchanged): ");
                string name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name)) obj2.Name = name;

                Console.WriteLine("Enter new Job (leave blank to keep unchanged): ");
                string job = Console.ReadLine();
                if (!string.IsNullOrEmpty(job)) obj2.Job = job;

                Console.WriteLine("Enter new Salary (leave blank to keep unchanged): ");
                if (decimal.TryParse(Console.ReadLine(), out decimal salary)) obj2.Salary = salary;

                Console.WriteLine("Enter new Deptno (leave blank to keep unchanged): ");
                if (int.TryParse(Console.ReadLine(), out int deptno)) obj2.Deptno = deptno;

                Console.WriteLine("Employee updated successfully.");
            }
            else
            {
                Console.WriteLine($"Employee with ID {eId} does not exist.");
            }
        }
    }

    class Program
    { 
            static void Main(string[] args)
            {
                int choice = 0;

                EmployeeManagement empManagement = new EmployeeManagement();

                Console.WriteLine("*******  Perform CRUD Operations on List of Employees *******");

                do
                {
                    Console.WriteLine("1. Add Employee");
                    Console.WriteLine("2. Remove Employee");
                    Console.WriteLine("3. Show Employees");
                    Console.WriteLine("4. Update Employees");                   
                    Console.WriteLine("5. Exit");

                    Console.WriteLine("Enter your choice (1 to 5) : ");
                    choice = int.Parse(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:
                            empManagement.AddEmployee();
                            break;
                        case 2:
                            empManagement.RemoveEmployee();
                            break;
                        case 3:
                            empManagement.ShowEmployees();
                            break;
                        case 4:
                            empManagement.UpdateEmployee();
                            break;

                        case 5: break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }


                    Console.WriteLine("\n----------------------------------------");

                } while (choice != 5);


                Console.WriteLine("Thank you. Visit Again...!");
                Console.ReadLine();
            }
        }    
}
