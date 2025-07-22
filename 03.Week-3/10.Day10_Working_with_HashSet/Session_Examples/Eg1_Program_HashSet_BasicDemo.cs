using System.Collections.Generic;

namespace ConsoleApp39
{    
 
    class Program
    { 
            static void Main(string[] args)
            {
                HashSet<int> numbers = new HashSet<int>() { 1, 2, 3 };

                Console.WriteLine(numbers.Add(5));  // True
                Console.WriteLine(numbers.Add(2));  // False
                Console.WriteLine(numbers.Add(4));  // True
                Console.WriteLine(numbers.Add(3));  // False
              

            Console.WriteLine(string.Join(",", numbers));


            // Iteration of HashSet
            //foreach (var item in numbers)
            //{
            //    Console.Write($"{item} , ");
            //}
            ;

            Console.ReadLine();
            }
        }    
}
