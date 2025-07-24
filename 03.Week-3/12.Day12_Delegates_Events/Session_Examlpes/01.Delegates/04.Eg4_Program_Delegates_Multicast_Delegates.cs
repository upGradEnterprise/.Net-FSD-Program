

namespace ConsoleApp39
{

    public delegate void MathDelegate(int x, int y);

    public class MathTest
    {
        public void Sum(int x, int y)
        {
            Console.WriteLine("Sum method is invoked");
            Console.WriteLine($"Sum Result : {x + y}");
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine("Sub method is invoked");
            Console.WriteLine($"Subtract Result : {x - y}");
        }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            MathTest mathTest = new MathTest();
            
            // Multicast Delegates
            
            MathDelegate d3 = new MathDelegate(mathTest.Sum);

            d3(5, 3);
            Console.WriteLine("------------------------");

            d3 += new MathDelegate(mathTest.Sub);
            d3(5, 3);


            Console.WriteLine("------------------------");
            d3 -= new MathDelegate(mathTest.Sum);
            d3(5, 3);


            Console.ReadLine();
        }
    }
}