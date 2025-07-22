using System.Collections.Generic;

namespace ConsoleApp39
{    
 
    class Program
    { 
            static void Main(string[] args)
            {
                HashSet<int> set1 = new HashSet<int>() { 2, 4, 6, 8, 10, 12 };
                HashSet<int> set2 = new HashSet<int>() { 3, 6, 9, 12, 15  };
                
                HashSet<int> set3 = new HashSet<int>(set1);
                set3.UnionWith(set2);

                Console.WriteLine("Set-1 : " + string.Join(",", set1));
                Console.WriteLine("Set-2 : " + string.Join(",", set2));
                Console.WriteLine("Set-3 : " + string.Join(",", set3));

                Console.ReadLine();
            }
        }    
}
