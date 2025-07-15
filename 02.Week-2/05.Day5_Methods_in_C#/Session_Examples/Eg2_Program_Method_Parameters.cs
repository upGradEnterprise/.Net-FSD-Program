


namespace ConsoleApp39
{
    internal class Program
    {
        
        // Default / Optional Parameters
        static void GetTotalAmount(string productName,  double unitPrice, int qty = 1)
        {
            double totalAmount = unitPrice * qty;
            Console.WriteLine($"{productName}, {qty}, {unitPrice}, {totalAmount}");
        }

        // Params : Unlimited / variable no. of parameters
        static void GetSum(params int[] numbers)
        {
            int sum = 0;

            foreach (int item in numbers)
            {
                sum += item;
            }

            Console.WriteLine($"Sum Result : {sum}");
        }

        // Usage ref
        static void Swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }

        // Usage of out 
        static void Divide(int dividend, int divisor, out int quotient, out int reminder)
        {
            quotient = dividend / divisor;
            reminder = dividend % divisor;
        }

        static void Main(string[] args)
        {

            // Optional Parameters
            GetTotalAmount("Laptop", 30000, 2);
            GetTotalAmount("Mobile", 25000);
            GetTotalAmount("Tab", 45000);

            Console.WriteLine("----------------------------");

            // Usage of Params :  variable no. of params
            GetSum(10);
            GetSum(10, 20, 30);
            GetSum(10, 20, 30, 40, 50, 60);
            GetSum(10, 20);
            GetSum(10, 20, 30, 40);

            Console.WriteLine("----------------------------");

            // Usage of ref
            int a = 10, b = 20;
            Console.WriteLine($"Before Swapping :   A = {a}, B = {b}");
            Swap(ref a, ref b); 
            Console.WriteLine($"After Swapping  :   A = {a}, B = {b}");
            
            
            Console.WriteLine("----------------------------");
            int x = 34, y = 5;
           // int resultQuotient, resultReminder;

            Divide(x,y, out int resultQuotient, out int resultReminder);

            Console.WriteLine($"Quotient : {resultQuotient}");
            Console.WriteLine($"Reminder : {resultReminder}");

            Console.ReadLine();
        }
    }
}
