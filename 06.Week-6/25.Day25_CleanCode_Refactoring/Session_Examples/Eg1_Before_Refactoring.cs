

namespace Console43
{
    // Before Refactor
    public class OrderService
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Validate Order");
            Console.WriteLine("Save Order");
            Console.WriteLine("Send Email Confirmation");
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            var orderService = new OrderService();
            orderService.PlaceOrder();

            Console.ReadLine();
        }
    }


    

}