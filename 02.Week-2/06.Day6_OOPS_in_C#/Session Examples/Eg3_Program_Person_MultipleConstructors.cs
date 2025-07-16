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

        public void SetDetails(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Name :  {_name}, Age : {_age}");             
        }
    }

    internal class Program
    {   
        static void Main(string[] args)
        {  
            Person p1 = new Person();            
            Person p2 = new Person("Smith");            
            Person p3 = new Person("Sandy", 25);     
            

            p1.ShowDetails();
            p2.ShowDetails();
            p3.ShowDetails();
            
            Console.ReadLine();         
        } 
    }
}
