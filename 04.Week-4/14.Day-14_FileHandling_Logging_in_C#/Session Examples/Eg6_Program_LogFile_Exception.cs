using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp41
{
    
    class Program
    {
        static void Main()
        {

            string logPath = Path.Combine("Logs", "program_logs.txt");
			Directory.CreateDirectory("Logs");            

            try
            {

                Console.Write("Enter numerator: ");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter denominator: ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denominator;
                Console.WriteLine($"Result: {result}");

                using (StreamWriter sw = new StreamWriter(logPath, true))
                {
                    sw.WriteLine($"[INFO] Message: Calculation attempt completed. Date-Time : {DateTime.Now}");
                } 
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception Message: Cannot divide by zero.");

                using (StreamWriter sw = new StreamWriter(logPath, true))
                {
                    sw.WriteLine($"[Exception] Message: Cannot divide by zero. Date-Time : {DateTime.Now}");
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Exception Message: Please enter valid numbers.");

                using (StreamWriter sw = new StreamWriter(logPath, true))
                {
                    sw.WriteLine($"[Exception] Message: Please enter valid numbers. Date-Time : {DateTime.Now}");
                }
            }
            finally
            {
                Console.WriteLine("Calculation attempt completed.");
            }




            Console.ReadLine();

        }
    }
    }

 