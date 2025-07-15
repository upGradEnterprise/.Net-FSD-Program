namespace ConsoleApp39
{

    class Product
    {
        public string Name;
        public int Quantity;
        public double UnitPrice;

        public Product(string name, int quantity, double unitPrice)
        {
            Name = name;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }

    class Order
    {
        public string CustomerName;
        public Product[] Items;
    }

    internal class Program
    {

        public static void ProcessOrder(Order order)
        {
            // Step 1: Validate Order
            if (!ValidateOrder(order))
            {
                return;
            }

            // Step 2: Calculate Total
            double total =  CalculateTotal(order);  

            // Step 3: Apply Discount
            total = ApplyDiscount(total);

            // Step 4: Save Order to Database (mocked)
            SaveOrder(order);

            // Step 5: Send Confirmation Email (mocked)
            SendConfirmation(order.CustomerName, total);
        }

        static bool ValidateOrder(Order order)
        {
            Console.WriteLine("Validate Order Method is executing");

            if (order == null || string.IsNullOrEmpty(order.CustomerName) || order.Items.Length == 0)
            {
                Console.WriteLine("Invalid order.");
                return false;
            }

            return true;
        }

        static double CalculateTotal(Order order)
        {
            Console.WriteLine("CalculateTotal Method is executing");

            double total = 0;
            foreach (var item in order.Items)
            {
                total += item.UnitPrice * item.Quantity;
            }
            return total;
        }

        static double ApplyDiscount(double total)
        {
            Console.WriteLine("ApplyDiscount Method is executing");
            return total > 15000 ? total * 0.9 : total;
        }

        static void SaveOrder(Order order)
        {
            Console.WriteLine("Saving order to database...");
            // Simulated DB logic
        }

        static void SendConfirmation(string customerName, double total)
        {
            Console.WriteLine($"Email sent to {customerName} with total INR.{total}");
        }

        static void Main(string[] args)
        {

            Order orderObj = new Order();
            orderObj.CustomerName = "Scott";

            orderObj.Items = new Product[3];
            orderObj.Items[0] = new Product("Laptop",2,26000);
            orderObj.Items[1] = new Product("Mobile",1,22000);
            orderObj.Items[2] = new Product("Tab",3,24000);


        //     ProcessOrder(null);
               ProcessOrder(orderObj);
         

            Console.ReadLine();
        }
    }
}
