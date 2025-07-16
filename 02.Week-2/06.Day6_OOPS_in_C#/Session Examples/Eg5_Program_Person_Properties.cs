namespace ConsoleApp39
{

    class Person
    {
        private string _name;    
        private int _age;

        public Person()
        {
            this._name = string.Empty;
            this._age = 0;           
        }

        public Person(string name)
        {
            this._name = name;
            this._age = 0;

        }

        public Person(string name, int age)
        {
            this._name = name;
            this._age = age;
            
        }

        // Properties
        public int Age
        {
            get { return this._age; }
            set { 
                if(value >= 0 && value <=150)
                    this._age = value; 
                else
                    Console.WriteLine("Invalid Age");
            }  
        }

        public string Name
        {
            get { return this._name; } 
            set { this._name = value; }         
        }        
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
