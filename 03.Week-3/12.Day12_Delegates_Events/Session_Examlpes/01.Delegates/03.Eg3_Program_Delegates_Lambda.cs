

namespace ConsoleApp39
{

    public delegate int MathDelegate(int x);


    
    class Program
    { 
        static void Main(string[] args)
        {
            // Lambda Expression

            MathDelegate d1 = (x) =>
            {
                return x * 2;
            };

            Console.WriteLine( d1(15) );
            Console.WriteLine( d1(16) );

            Console.WriteLine("--------------");

            MathDelegate d2 = x => x * 10;
            Console.WriteLine(d2(5));
            Console.WriteLine(d2(6));

            Console.WriteLine("--------------");

            MathDelegate d3 = x => x * x;
            Console.WriteLine(d3(8));
            Console.WriteLine(d3(9));

            Console.ReadLine();
        }
    }
}