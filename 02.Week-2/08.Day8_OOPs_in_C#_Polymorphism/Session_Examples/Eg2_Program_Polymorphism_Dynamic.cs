using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39 
{ 
    class Person
    {
        public virtual void Print()
        {
            Console.WriteLine("Person details from parent class.");
        }
    }
    class Employee : Person
    {
        public override void Print()
        {
            Console.WriteLine("Employee details from child class");
        }
    }
    class Student : Person
    {
        public override void Print()
        {
            Console.WriteLine("Student details from child class");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person;

            person = new Person();
            person.Print();

            person = new Student();
            person.Print();

            person = new Employee();
            person.Print();

            Console.ReadLine();
        }
    }
}
