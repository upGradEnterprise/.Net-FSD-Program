namespace ConsoleApp39
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Greeting();
            System.Console.WriteLine("--------------------------------");
            Greeting(4);
            System.Console.WriteLine("--------------------------------");
            Greeting("Scott");
            System.Console.WriteLine("--------------------------------");
            Greeting("Scott", "Morning");
            System.Console.WriteLine("--------------------------------");
            Greeting("Scott", 3);
            System.Console.WriteLine("--------------------------------");
            Greeting(3, "Scott");
            System.Console.WriteLine("--------------------------------");
        
            Console.ReadLine(); 
        
        }

        static void Greeting()
        {
            Console.WriteLine("Welcome to C# Methods");
        }

        static void Greeting(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Hi , How are you?");
            }
        }

        static void Greeting(string uname)
        {
            Console.WriteLine("Welcome to " + uname);
        }

        static void Greeting(string uname, string timeOfDay)
        {
            Console.WriteLine("Hi {0}, Good {1}...!", uname, timeOfDay);
        }

        static void Greeting(string uname, int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Welcome to " + uname);
            }
        }

        static void Greeting(int number, string uname)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Welcome to " + uname);
            }
        }
    }
}
