using System.Collections.Generic;


namespace ConsoleApp39
{

    class OrderItem
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}\tName: {ProductName}\tQuantity: {Quantity}\tTotal: {Total}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> priceList = new Dictionary<string, double>()
            {
                {"Apple",100 },
                {"Orange", 120 },
                {"Banana",80 },
                {"Lemon",60 }
            };

            List<OrderItem> items = new List<OrderItem>()
            {
                new OrderItem() {Id = 101, ProductName= "Apple", Quantity=20},
                new OrderItem() {Id = 102, ProductName= "Orange", Quantity=30},
                new OrderItem() {Id = 103, ProductName= "Banana", Quantity=25},
                new OrderItem() {Id = 104, ProductName= "Lemon", Quantity=50},
                new OrderItem() {Id = 105, ProductName = "Mobile", Quantity=12}
            };

            double grandTotal = 0.0;

            foreach(var item in items)
            {

                if (priceList.TryGetValue(item.ProductName, out double price))
                {
                    item.Total = item.Quantity * price;
                    grandTotal += item.Total;
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine($"{item.ProductName} is not in the Price List.");
                }
                
            }

            Console.WriteLine($"The Grand Total is : {grandTotal}");



            Console.ReadLine();
        }
    }
}
