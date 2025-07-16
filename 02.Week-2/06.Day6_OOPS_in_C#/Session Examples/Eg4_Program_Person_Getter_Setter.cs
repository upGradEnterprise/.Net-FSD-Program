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

        public void SetName(string name)
        {
            this._name = name;            
        }

        public void SetAge(int age)
        {
            if (age > 0 && age < 150)
            {
                this._age = age;
            }
            else
            {
                Console.WriteLine("Invalid Age");
               // throw new Exception("Invalid Age");
            }

        }

        public int GetAge()
        {
            return this._age;
        }

        public string GetName()
        {
            return this._name;
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
           
           
            p1.SetName("Scott");
            p1.SetAge(25);


            Console.WriteLine($"Hi {p1.GetName()}, Good morning...!");
            Console.WriteLine($"Name : {p1.GetName()}, Age : {p1.GetAge()}");




            Console.ReadLine();         
        } 
    }
}
