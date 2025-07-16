namespace ConsoleApp39
{

    class Person
    {
        private string _name;    
        private int _age;

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
            p1.SetDetails("Scott", 25);
            p1.ShowDetails();


            Person p2 = new Person();
            p2.SetDetails("Smith", 35);
            p2.ShowDetails();

            Console.ReadLine();         
        } 
    }
}
