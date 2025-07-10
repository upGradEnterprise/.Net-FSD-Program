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
            int x = 10;
            bool y = false;
            double z = 5454.45;

            object obj;


            obj = x;    // boxing 
            int a = (int) obj;  // unboxing
            //  bool a = (bool)obj;     // no error,  throws exception : Invalid Cast Excpetion
            Console.WriteLine($"A = {a}");


            obj = y; // boxing 
            bool b = (bool) obj; // unboxing
            Console.WriteLine($"B = {b}");


            obj = z; // boxing 
            double c = (double)obj; // unboxing
            Console.WriteLine($"C = {c}");

            Console.ReadLine();
        }
    }
}