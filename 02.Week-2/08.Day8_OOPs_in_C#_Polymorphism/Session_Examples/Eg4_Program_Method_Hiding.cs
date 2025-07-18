using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39 
{ 
    class Person
    {
        public void Print()
        {
            Console.WriteLine("Person details from parent class.");
        }
    }
    class Employee : Person
    {
		// It hides the parent class Print() method
        public new void Print()
        {
            Console.WriteLine("Employee details from child class");
        }
    }
     


    class Program
    {
       
        static void Main(string[] args)
        {
            Person person;

            person = new Person();
            person.Print();  // Output: Person details from parent class

            person = new Employee();
            person.Print();  // Output: Person details from parent class
			
			
			 


            Console.ReadLine();
        }
    }
}
