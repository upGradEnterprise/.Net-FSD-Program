using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp39
{
    class Program
    {

        static void PerformReadDivision()
        {
            Console.Write("Enter numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            PerformDivision(numerator, denominator);
        }


        static  void PerformDivision(int numerator, int denominator)
        {
            int result = numerator / denominator;
            Console.WriteLine($"Result: {result}");
        }

        static void Main()
        {
            try
            {
                PerformReadDivision();
            }           
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Message: {ex.Message}.");
                Console.WriteLine($"Stack Trace  :  {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Calculation attempt completed.");
            }




            Console.ReadLine();

        }
    }
}
