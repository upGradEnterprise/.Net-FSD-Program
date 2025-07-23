using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp39
{    
    public class Program
    {
        static void Main()
        {
            int[] arr1 = [8, 5, 4, 9, 6, 2, 3, 7, 12, 18, 22];


            // LINQ Query
            var arr2 = from n in arr1
                       where n % 2 == 0 && n < 10
                       orderby n
                       select n;


            //  Expression Methods
            var arr3 = arr1
                        .Where(x => x % 2 == 0 && x < 10)
                        .OrderBy(x => x);

            Console.WriteLine(string.Join(",", arr1));
            Console.WriteLine(string.Join(",", arr2));
            Console.WriteLine(string.Join(",", arr3));

            Console.ReadLine();
        }
    }

}
