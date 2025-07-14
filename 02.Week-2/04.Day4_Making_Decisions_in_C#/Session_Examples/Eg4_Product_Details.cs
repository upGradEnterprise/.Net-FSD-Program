using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Product
    {
        public string Name;
        public int Quantity;
        public double Price;
        public double Total;
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter no. products to buy :  ");
            int productCount = int.Parse(Console.ReadLine());

            Product product = new Product();
            double grandTotal = 0;

            string finalReport = "";

            for (int i = 0; i < productCount; i++)
            {
                Console.WriteLine("Enter the product name:");
                product.Name = Console.ReadLine();

                Console.WriteLine("Enter the price:");
                product.Price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the quantity:");
                product.Quantity = Convert.ToInt32(Console.ReadLine());

                product.Total = product.Quantity * product.Price;

                finalReport += $" Product Id : {i + 1},  Name : {product.Name} , Price : {product.Price}, Quantity :  {product.Quantity}, Total Price :  {product.Total}  \n";


                grandTotal = grandTotal + product.Total;

            }

            Console.WriteLine("The Final Products Report");
            Console.WriteLine(finalReport);
            Console.WriteLine($"Grandtotal= {grandTotal}");

            Console.ReadLine();
        }
    }
}
