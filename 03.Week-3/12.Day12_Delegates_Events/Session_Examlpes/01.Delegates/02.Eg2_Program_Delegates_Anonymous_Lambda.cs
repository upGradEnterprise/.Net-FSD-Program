

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

            // 1.  Standard Approach 
            MathDelegate d1 = new MathDelegate(mathTest.Sum);
            d1(10,20);


            MathDelegate d2 = new MathDelegate(mathTest.Sub);
            d2(40, 15);
            Console.WriteLine("-------------------------------------");

            // 2. Anonymous method
            MathDelegate d3 = new MathDelegate(delegate (int x, int y)
            {
                Console.WriteLine("Multiply method is invoked");
                Console.WriteLine($"Multiply Result : {x * y}");
            });

            d3(15, 6);
            Console.WriteLine("--------------------------");

            // 3. Lambda Expression
            MathDelegate d4 = new MathDelegate( (x,y) =>
            {
                Console.WriteLine("Div method is invoked");
                Console.WriteLine($"Div  Result : {x / y}");
            });

            

            Console.ReadLine();
        }
    }
}