using System.Collections.Generic;

namespace ConsoleApp39
{    
 
    class Program
    { 
            static void Main(string[] args)
            {
                HashSet<int> set1 = new HashSet<int>() { 2, 4, 6, 8, 10, 12 };
                HashSet<int> set2 = new HashSet<int>() { 3, 6, 9, 12, 15  };
                            
                Console.WriteLine("Set-1 : " + string.Join(",", set1));
                Console.WriteLine("Set-2 : " + string.Join(",", set2));


            //     set1.UnionWith(set2); 2,4,6,8,10,12,3,9,15
            //    set1.IntersectWith(set2); // 6,12
                   set1.ExceptWith(set2);    // 2,4,8,10
                  Console.WriteLine("Resulted  Set-1 : " + string.Join(",", set1));

            Console.ReadLine();
            }
        }    
}
