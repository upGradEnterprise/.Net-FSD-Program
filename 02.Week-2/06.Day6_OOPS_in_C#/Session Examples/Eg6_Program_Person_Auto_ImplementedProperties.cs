namespace ConsoleApp39
{

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {  
        static void Main(string[] args)
        {
            Person p1 = new Person(); 

            p1.Name = "Scott";  // Set
            p1.Age = 23;  // Set  

            Console.WriteLine($"Hi {p1.Name}, Good morning...!");
            Console.WriteLine($"Name : {p1.Name}, Age : {p1.Age}"); 

            Console.ReadLine();         
        } 
    }
}
