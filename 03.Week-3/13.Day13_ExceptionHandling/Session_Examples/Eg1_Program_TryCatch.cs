using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp39
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter numerator: ");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter denominator: ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denominator;
                Console.WriteLine($"Result: {result}");

                 int[] ar = new int[2];
                 ar[10] = 1;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception Message: Cannot divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Exception Message: Please enter valid numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Message: {ex.Message}.");
            }
            finally
            {
                Console.WriteLine("Calculation attempt completed.");
            }




            Console.ReadLine();

        }
    }
}
