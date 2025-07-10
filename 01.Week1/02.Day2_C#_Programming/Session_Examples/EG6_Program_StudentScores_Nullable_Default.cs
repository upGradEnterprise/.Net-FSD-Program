using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
     class Program
    {

        static void DisplayResult(string studentName, int? score = default)
        {
            string name = studentName;

            //  int displayScore = score.HasValue ? score.Value : 0;
            int displayScore = score ?? 0;    

            Console.WriteLine($"Student: {name}");

            if (score.HasValue)
            {
                Console.WriteLine($"Score: {displayScore}/100");
            }
            else
            {
                Console.WriteLine("No score available yet.");
            }

            Console.WriteLine("------------------------------");

        }
        

        static void Main()
        {

            DisplayResult("Scott", 86);
            DisplayResult("Smith");
            DisplayResult("Sam",  69);
            DisplayResult("Bob");
           
            Console.ReadLine();
        }
    }
}