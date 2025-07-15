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
            if (order == null || string.IsNullOrEmpty(order.CustomerName) || order.Items.Length == 0)
            {
                Console.WriteLine("Invalid order.");
                return;
            }

            // Step 2: Calculate Total
            double total = 0;
            foreach (var item in order.Items)
            {
                total += item.Quantity * item.UnitPrice;
            }

            // Step 3: Apply Discount
            if (total > 5000)
            {
                total *= 0.9; // 10% discount
            }

            // Step 4: Save Order to Database (mocked)
            Console.WriteLine("Saving order to database...");


            // Step 5: Send Confirmation Email (mocked)
            Console.WriteLine($"Email sent to {order.CustomerName} with total INR.{total}");

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
