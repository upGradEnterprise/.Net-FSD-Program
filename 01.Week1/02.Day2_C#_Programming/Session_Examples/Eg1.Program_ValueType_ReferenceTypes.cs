using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = a;

            Console.WriteLine($"a = {a}, b = {b}");
            b = 15;

            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine("------------------------");


            string s1 = "Hello";
            string s2 = s1;

            Console.WriteLine($"s1 = {s1}, s2 = {s2}");
            s2 = "World";
            Console.WriteLine($"s1 = {s1}, s2 = {s2}"); 

         

            Console.WriteLine("------------------------");
            object obj1 = 123;

            object obj2 = obj1;
            Console.WriteLine($"obj1 = {obj1}, obj2 = {obj2}");

            obj2 = 456;
            Console.WriteLine($"obj1 = {obj1}, obj2 = {obj2}");



            Console.ReadLine();

        }
    }
}
