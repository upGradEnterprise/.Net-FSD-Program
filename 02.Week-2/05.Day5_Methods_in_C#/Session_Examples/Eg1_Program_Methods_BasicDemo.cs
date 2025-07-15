


namespace ConsoleApp39
{
    internal class Program
    {
        static void Greeting()
        {
            Console.WriteLine("Welcome to C# Methods");
        }

        static void GreetingByName(string name)
        {
            Console.WriteLine($"Hi {name}, Good morning...!");
        }

        static int GetSum(int x, int y)
        {
            int z = x + y;
            return z;
        }

        static string GetCurrentTime()
        {
            string str = DateTime.Now.ToString("T");
            return str;
        }


        static void Main(string[] args)
        {
            Greeting();
            Greeting();
            Console.WriteLine("-------------------------");
            GreetingByName("Ralph");
            GreetingByName("Scott");
            Console.WriteLine("-------------------------");

            int result = GetSum(10, 20);
            Console.WriteLine($"Sum Result : {result}");

            Console.WriteLine("-------------------------");

            string strCurrentTime = GetCurrentTime();
            Console.WriteLine($"Current Time : " + strCurrentTime);

            Console.ReadLine();
        }
    }
}
