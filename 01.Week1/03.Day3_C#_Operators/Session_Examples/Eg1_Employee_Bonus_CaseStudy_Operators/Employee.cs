using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Employee
    {
        public decimal Salary;
        public int NoOfYearsExp;
        public bool IsHighPerformer;

        public bool ValidateEmployeeData()
        {
            bool isValid = false;

            if( (NoOfYearsExp >= 1 && NoOfYearsExp <= 40) && Salary >= 10000)
            {
                isValid = true; 
               
            }
            
            return isValid;
        }

        public decimal GetBonus()
        {
            decimal bonus = 0;

            if (IsHighPerformer || (NoOfYearsExp >= 5  &&  Salary > 30000) ) {
                bonus = Salary * 0.1m;
            }
                       
            return bonus;
        }
    
    
    
        public void DisplayDetails(decimal bonusAmount)
        {
            Console.WriteLine($"Actual Salary:  {Salary:F2}");
            Console.WriteLine($"Years of Exp. :  {NoOfYearsExp}  years");
            Console.WriteLine($"Is High Performer :  {IsHighPerformer}");
            Console.WriteLine($"Bonus Amount :  {bonusAmount:F2}");
        }
    }
}
