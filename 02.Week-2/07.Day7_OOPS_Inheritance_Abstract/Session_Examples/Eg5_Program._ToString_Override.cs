using System.Net;

namespace ConsoleApp39
{

    class Employee
    {
        // Properties
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{EmpId}, {Name}, {Salary}"; ;
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {

            Program obj = new Program();
            Console.WriteLine(obj);
            Console.WriteLine(obj.ToString());

            DateTime d1 = new DateTime();
            Console.WriteLine(d1);

            Employee empObj = new Employee();
            empObj.EmpId = 10256;
            empObj.Name = "Scott";
            empObj.Salary = 45000;

            Console.WriteLine(empObj); //  invokes ToString() internally
            Console.WriteLine(empObj.ToString());


            Console.ReadLine();
        }
    }
}
