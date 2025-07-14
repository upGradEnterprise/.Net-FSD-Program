using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            int deptNumber;

            Console.WriteLine("Enter Dept Number : ");
            deptNumber = int.Parse(Console.ReadLine());

            switch(deptNumber)
            {
                case 10:
                    Console.WriteLine("You are belongs ACCOUNTS dept.");
                    break;
                case 20:
                    Console.WriteLine("You are belongs SALES dept.");
                    break;
                default:
                    Console.WriteLine("Invalid department or Department does not exists");
                    break;
            }


            Console.ReadLine();

        }
    }
}
