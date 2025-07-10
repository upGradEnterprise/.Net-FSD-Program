using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
     class Program
    { 
        static void Main()
        {

            int? x = default;

            if (x.HasValue)
            {
                Console.WriteLine($"X value : {x}");
            }


            int y = default;
            Console.WriteLine($"Y value : {y}");

            Console.ReadLine();
        }
    }
}