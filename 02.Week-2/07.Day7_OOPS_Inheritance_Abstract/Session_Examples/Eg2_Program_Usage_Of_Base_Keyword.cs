namespace ConsoleApp39
{

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

     //   public Person( )  => Name = string.Empty;
        public Person(string name)  => Name = name;

        public virtual void ShowDetails() => Console.WriteLine($"Name : {Name}, Age : {Age}");

    }



    class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string Job { get; set; }

        public Employee(string name) : base(name)
        {

        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Employee Id : {EmployeeId}, Job : {Job}");
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
          
            Employee employee = new Employee("Narasimha Rao");
            employee.EmployeeId = 6445454; 
            employee.Age = 32;
            employee.Job = "Manager";


            employee.ShowDetails();

            Console.ReadLine();
        }
    }
}
