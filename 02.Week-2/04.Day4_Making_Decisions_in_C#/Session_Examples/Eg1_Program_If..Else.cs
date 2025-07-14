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
            int a = 150, b = 150, c = 250;

            int greater = 0;

            
            if (a >= b  && a >= c)
            {
                greater = a;             
            }
            else  if(b >= a && b >= c)
            {
                greater = b;
            }
            else 
            {
                greater = c;
            }

            Console.WriteLine($"Greater Number : {greater}");

            Console.ReadLine();

        }
    }
}
