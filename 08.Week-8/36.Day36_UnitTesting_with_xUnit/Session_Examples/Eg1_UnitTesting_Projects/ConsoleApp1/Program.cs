using MathUtilityLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        MathUtility mathUtility = new MathUtility ();

        Console.WriteLine("Sum Result  : "  +  mathUtility.Sum(10,20));
        Console.WriteLine("Subtract Result  : "  +  mathUtility.Subtract(120,50));



        Console.ReadLine();

    }
}