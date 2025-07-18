using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
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
                int? n = item as int?;

                if (n.HasValue)
                {
                    sum += n.Value;
                    Console.WriteLine($"Processed int: {n.Value}");
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