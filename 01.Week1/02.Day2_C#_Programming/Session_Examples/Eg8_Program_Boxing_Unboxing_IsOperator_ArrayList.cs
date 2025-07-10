using System;
using System.Collections;
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
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add(2);
            arrList.Add("three");
            arrList.Add(4);
            arrList.Add(false);  
            
            int sum = 0;

            foreach (object item in arrList)
            {
                if(item is int n)
                {
                    sum += n;
                    Console.WriteLine($"Processed int: {n}");
                }
                else
                {
                    Console.WriteLine($"Non-int value: {item}");
                }
               
            }

            Console.WriteLine($"Sum Result : {sum}");


            Console.ReadLine();
        }
    }
}