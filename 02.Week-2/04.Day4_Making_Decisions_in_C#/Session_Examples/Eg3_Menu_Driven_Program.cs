 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Program
    {     
        
        static void ShowEvenNumbers()
        {
            int i = 0;

            while(i <= 20)
            {
                Console.Write($"{i}  ");
                i += 2;
            }
        }

        static void ShowOddNumbers()
        {
            int i = 1;

            do
            {
                Console.Write($"{i}  ");
                i += 2;
            } while (i <= 20);
        }

        static void ShowFiveMultiples()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i * 5}  ");
            }
        }

        static void ShowSquares()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i * i}  ");
            }
        }
        static void Main(string[] args)
        {
            int choice = 0;

            do
            {
                Console.WriteLine("1. Even Numbers");
                Console.WriteLine("2. Odd Numbers");
                Console.WriteLine("3. Five Multiples");
                Console.WriteLine("4. Squares");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter your choice (1 to 5) : ");
                choice = int.Parse(Console.ReadLine());


                switch(choice)
                {
                    case 1:
                        ShowEvenNumbers();
                        break;
                    case 2:
                        ShowOddNumbers();
                        break;
                    case 3:
                        ShowFiveMultiples();
                        break;
                    case 4:
                        ShowSquares();
                        break;

                    case 5:   break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }


                Console.WriteLine("\n----------------------------------------");

            } while (choice != 5);


            Console.WriteLine("Thank you. Visit Again...!");
            Console.ReadLine();
        }
    }
}
