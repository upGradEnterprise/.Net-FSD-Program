using System.Threading.Channels;

namespace ConsoleApp39
{


    public class NotificationEventArgs : EventArgs
    {
        public string Message{ get; set; }
        public DateTime OrderPlacedDateTime{ get; set; }
    }

     
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string PhoneNumber { get; set; }
    }

    public delegate void OrderNotificationHandler(Order order, NotificationEventArgs e);

    public class OrderProcessor
    {
        public event OrderNotificationHandler OnOrderPlaced;

        public void PlaceOrder(Order order)
        {
            Console.WriteLine($"Order : #{order.OrderId} placed.");
            if( OnOrderPlaced != null)
            {
                NotificationEventArgs e = new NotificationEventArgs()
                {
                    Message = $"Order : #{order.OrderId} placed. Prodcut will dispatch in another 3 working days",
                    OrderPlacedDateTime = DateTime.Now,
                };

                OnOrderPlaced.Invoke(order, e);    
            }
        }
    }
 


    public class  NotificationService
    {
        public void SendEmail(Order order, NotificationEventArgs e)
        {
            Console.WriteLine($"Hi {order.CustomerName}, Email send to {order.CustomerEmail}");
            Console.WriteLine($"Message : {e.Message}");
            Console.WriteLine($"Order Placed On:  {e.OrderPlacedDateTime.ToString()}");
        }

        public void SendSMS(Order order, NotificationEventArgs e)
        {
            Console.WriteLine($"Hi {order.CustomerName}, SMS Message send to {order.PhoneNumber}");
            Console.WriteLine($"Message : {e.Message}");
            Console.WriteLine($"Order Placed On:  {e.OrderPlacedDateTime.ToString()}");
        }

        public void SendWhatsApp(Order order, NotificationEventArgs e)
        {
            Console.WriteLine($"Hi {order.CustomerName}, WhatsApp Message send to {order.PhoneNumber}");
            Console.WriteLine($"Message : {e.Message}");
            Console.WriteLine($"Order Placed On:  {e.OrderPlacedDateTime.ToString()}");
        }

    }


    class Program
    {
        static void Main()
        {

            Order order = new Order()
            {
                OrderId = 21561,
                CustomerName = "Scott",
                CustomerEmail = "scott@gmail.com",
                PhoneNumber = "984556454"
            };

            NotificationService service = new NotificationService();    

            OrderProcessor processor = new OrderProcessor();
            processor.OnOrderPlaced += service.SendEmail;

            processor.PlaceOrder(order);
            Console.WriteLine("-------------------------------");

            processor.OnOrderPlaced += service.SendSMS;
            processor.PlaceOrder(order);

            
            Console.WriteLine("-------------------------------");
            processor.OnOrderPlaced += service.SendWhatsApp;
            processor.PlaceOrder(order);


            Console.WriteLine("-------------------------------");
            processor.OnOrderPlaced -= service.SendSMS;
            processor.PlaceOrder(order);

            Console.ReadLine();



        } 
    } 

}