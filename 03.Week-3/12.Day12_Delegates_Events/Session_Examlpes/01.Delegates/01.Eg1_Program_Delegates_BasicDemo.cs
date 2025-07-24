

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

            MathDelegate d1 = new MathDelegate(mathTest.Sum);
            d1(10,20);

            MathDelegate d2 = new MathDelegate(mathTest.Sub);
            d2(40, 15);

            

            Console.ReadLine();
        }
    }
}