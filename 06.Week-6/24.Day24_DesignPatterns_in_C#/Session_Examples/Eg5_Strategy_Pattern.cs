
namespace Console43
{
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }

    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(double amount) => Console.WriteLine($"Paid {amount} using Credit Card.");
    }

    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(double amount) => Console.WriteLine($"Paid {amount} using PayPal.");
    }

    public class PaymentContext
    {
        private IPaymentStrategy _strategy;
        public PaymentContext(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }
        public void ExecutePayment(double amount)
        {
            _strategy.Pay(amount);
        }
    }



 
   
    public class Program
    {
        static void Main(string[] args)
        {
            // Usage
            var context = new PaymentContext(new CreditCardPayment());
            context.ExecutePayment(150);

            Console.ReadLine();
        }
    }


}