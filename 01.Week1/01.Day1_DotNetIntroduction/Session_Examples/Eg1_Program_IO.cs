using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("Enter your name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age : ");
            age = int.Parse(Console.ReadLine());


            //    Console.WriteLine("Hi " + name + ", Good afternoon...!");
            Console.WriteLine($"Hi {name} , Good afternoon...!");

            Console.WriteLine($"User Details :  {name}, {age}");


            Console.ReadLine();
        }
    }
}
