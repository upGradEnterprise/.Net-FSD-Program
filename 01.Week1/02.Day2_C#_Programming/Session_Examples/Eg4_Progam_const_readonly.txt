using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Store
    {
        // Fixed discount rate (never changes)
        public const double DISCOUNT_RATE = 0.10; // 10% discount


        // Store name, set once and cannot change
        public readonly string StoreName;


        // Constructor
        public Store(string storeName)
        {
            StoreName = storeName;
        }

        public void CalculateDiscountedPrice(double price)
        {
            //  DISCOUNT_RATE = 0.20;   // Error
            //  StoreName = "Updted Store Name";  // Error

            double discount = price * DISCOUNT_RATE;
            double finalPrice = price - discount;

            Console.WriteLine($"Store : {StoreName}");
            Console.WriteLine($"Original Price : {price:F2}");
            Console.WriteLine($"Discount Amount : {discount:F2}");
            Console.WriteLine($"Final Price : {finalPrice:F2}");
        }


    }

    class Program
    {

        static void Main()
        {

            Store storeObj1 = new Store("ABC Mobile Store");
            storeObj1.CalculateDiscountedPrice(5200);

            Console.WriteLine("--------------------------------------");

            Store storeObj2 = new Store("BigC Mobile Store");
            storeObj2.CalculateDiscountedPrice(6200);


            Console.ReadLine();
        }
    }
}