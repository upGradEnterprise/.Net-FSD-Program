namespace Console43
{
    // After Refactor
    public class OrderService
    {
        public void PlaceOrder()
        {
            ValidateOrder();
            SaveOrder();
            SendEmail();
        }

        private void ValidateOrder() => Console.WriteLine("Validate Order");
        private void SaveOrder() => Console.WriteLine("Save Order");
        private void SendEmail() => Console.WriteLine("Send Email Confirmation");
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