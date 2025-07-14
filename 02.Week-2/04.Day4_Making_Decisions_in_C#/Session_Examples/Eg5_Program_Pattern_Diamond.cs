using System;


namespace ConsoleApp39
{ 
    class Program
    {
        static void Main()
        {
              Console.Write("Enter the number of rows for the diamond (half): ");
              int n = Convert.ToInt32(Console.ReadLine());

           

            // Upper Part of the diamond
            for (int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            // Bottom Part of the diamond
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}