namespace ConsoleApp39
{

    class Employee
    {
        public int EmployeeId { get; private set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public int Deptno { get; set; }

        public Employee(int id)
        {
            this.EmployeeId = id;   
        }

        public bool ValidateData()
        {
            bool flag = true;

            if(this.EmployeeId < 1000 || this.Deptno <0  || this.Salary  < 10000 || string.IsNullOrEmpty(Name))
            {
                flag = false;
            }

            return flag;
        }
            
        public void ShowDetails()
        {
            Console.WriteLine($"Id : {EmployeeId}, Name : {Name}, Job : {Job}, Salary :  {Salary}, Deptno : {Deptno}");
        }
    }

        internal class Program
    {  
        static void Main(string[] args)
        {
           Employee empObj = new Employee(1000);
          //  empObj.EmployeeId = 454545;  // Error:  Read-Only Property
            
            empObj.Name = "Scott";
            empObj.Salary = 15000;
            empObj.Job = "Lead";
            empObj.Deptno = 10;


            if (!empObj.ValidateData())
            {
                Console.WriteLine("Invalid Employee details");
                Console.ReadLine();
                return;
            }

            empObj.ShowDetails();




            Console.ReadLine();         
        } 
    }
}
