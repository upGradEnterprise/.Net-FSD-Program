using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class  Student
    {
        public int Id;
        public string Name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Scott";
            s1.Id = 10256;


            Student s2 = s1;
            Console.WriteLine($"s1 - Name :  {s1.Name}, s2 - Name :  {s2.Name}, ");

            s2.Name = "Smith";
            Console.WriteLine($"s1 - Name :  {s1.Name}, s2 - Name :  {s2.Name}, ");
            
            Console.ReadLine();

        }
    }
}
