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
            // Primitive types: int for whole numbers
            Console.WriteLine("Enter the first number:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int number2 = int.Parse(Console.ReadLine());

            // var for type inference
            var sum = number1 + number2; // Compiler infers sum as int
            

            Console.WriteLine($"The sum is: {sum}");


            Console.ReadLine();
        }
    }
}
