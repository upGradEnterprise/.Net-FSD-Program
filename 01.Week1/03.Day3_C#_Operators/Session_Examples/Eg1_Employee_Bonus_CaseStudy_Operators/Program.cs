using System;

namespace ConsoleApp37
{
     class Program
    {
        static void Main()
        {
            Employee empObj = new Employee();
            empObj.NoOfYearsExp = 6;
            empObj.Salary = 35000;
            empObj.IsHighPerformer = false;


            if( empObj.ValidateEmployeeData() == false)
            {
                Console.WriteLine("Invalid Employee Data");
                Console.ReadLine();
                return;
            }
        

            decimal bonusAmount = empObj.GetBonus();

            empObj.DisplayDetails(bonusAmount);


            Console.ReadLine();
        }
    }

}