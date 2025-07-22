using System.Collections.Generic;

namespace ConsoleApp39
{     
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> myHashSet = new HashSet<string> { "apple", "orange", "banana", "apple" };

            Console.WriteLine($"Before Remove. Count : {myHashSet.Count}");
            Console.WriteLine("Items : " + string.Join(",", myHashSet));
            Console.WriteLine("---------------------------------------");

            // Remove an element
            myHashSet.Remove("apple"); // myHashSet now contains {"orange", "banana"}

            Console.WriteLine($"After Remove. Count : {myHashSet.Count}");
            Console.WriteLine("Items : " + string.Join(",", myHashSet));
            Console.WriteLine("---------------------------------------");

            // Clear all elements
            myHashSet.Clear(); // myHashSet is empty
            Console.WriteLine($"After Clear. Count : {myHashSet.Count}");
            Console.WriteLine("Items : " + string.Join(",", myHashSet));
            Console.WriteLine("---------------------------------------");

            Console.ReadLine();
        }
    }    
}
