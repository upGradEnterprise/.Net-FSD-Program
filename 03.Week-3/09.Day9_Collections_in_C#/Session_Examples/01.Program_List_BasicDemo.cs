using System.Collections.Generic;


namespace ConsoleApp39
{ 
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cityList = new List<string>();

            cityList.Add("Hyderabad");
            cityList.Add("Mumbai");
            cityList.Add("New Delhi");
            cityList.Add("Kolkata");


            Console.WriteLine($"No. of Cities : {cityList.Count}");

            Console.Write("City Names  : ");
            foreach (string item in cityList)
            {
                Console.Write($"{item} , ");
            }

            Console.WriteLine();
            cityList.Add("Chennai");
            cityList.Add("Goa");

            Console.WriteLine($"No. of Cities : {cityList.Count}");

            Console.Write("City Names  : ");
            foreach (string item in cityList)
            {
                Console.Write($"{item} , ");
            }

            Console.WriteLine();
            cityList.Remove("Chennai");
            Console.WriteLine($"No. of Cities : {cityList.Count}");

            Console.Write("City Names  : ");
            foreach (string item in cityList)
            {
                Console.Write($"{item} , "); 
            }

            Console.WriteLine();
            bool flag = cityList.Contains("Chennai");
            Console.WriteLine($"Is Chennai exists in List : {flag}");


            Console.ReadLine();
        }
    }
}
