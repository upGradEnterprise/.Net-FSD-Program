 
using System;
using System.Collections.Generic;

namespace ConsoleApp43
{

    // ====== 1. Code Smell Example ======
    public class OrderServiceBad
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Validate Order");
            Console.WriteLine("Save Order");
            Console.WriteLine("Send Email Confirmation");
        }
    }

    public class OrderServiceGood
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


    // ====== 2. Factory Pattern ======
    public interface IShape { void Draw(); }

    public class Circle : IShape
    {
        public void Draw() => Console.WriteLine("Drawing Circle");
    }

    public class Square : IShape
    {
        public void Draw() => Console.WriteLine("Drawing Square");
    }

    public static class ShapeFactory
    {
        public static IShape GetShape(string shapeType) =>
            shapeType switch
            {
                "Circle" => new Circle(),
                "Square" => new Square(),
                _ => throw new ArgumentException("Invalid shape type")
            };
    }


    // ====== 3. Strategy Pattern ======
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) =>
            Console.WriteLine($"Paid {amount:C} using Credit Card");
    }

    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) =>
            Console.WriteLine($"Paid {amount:C} using PayPal");
    }

    public class PaymentProcessor
    {
        private readonly IPaymentStrategy _paymentStrategy;
        public PaymentProcessor(IPaymentStrategy strategy) => _paymentStrategy = strategy;
        public void ProcessPayment(decimal amount) => _paymentStrategy.Pay(amount);
    }


    // ====== 4. Builder Pattern ======
    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public override string ToString() => $"{Title}\n{Content}";
    }

    public class ReportBuilder
    {
        private readonly Report _report = new Report();

        public ReportBuilder SetTitle(string title) { _report.Title = title; return this; }
        public ReportBuilder SetContent(string content) { _report.Content = content; return this; }
        public Report Build() => _report;
    }


    // ====== 5. Singleton Pattern ======
    public sealed class AppConfig
    {
        private static AppConfig _instance;
        private static readonly object _lock = new object();
        public string ConnectionString { get; private set; }

        private AppConfig()
        {
            ConnectionString = "Server=.;Database=Demo;Trusted_Connection=True;";
        }

        public static AppConfig Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new AppConfig();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Refactoring With Design Patterns - DEMO START ===\n");

            // 1. Code Smell Demo
            Console.WriteLine("1. Code Smell: Long Method");
            var orderServiceBad = new OrderServiceBad();
            orderServiceBad.PlaceOrder();

            Console.WriteLine("\nRefactored Version:");
            var orderServiceGood = new OrderServiceGood();
            orderServiceGood.PlaceOrder();


            // 2. Factory Pattern Demo
            Console.WriteLine("\n2. Factory Pattern:");
            var shape = ShapeFactory.GetShape("Circle");
            shape.Draw();


            // 3. Strategy Pattern Demo
            Console.WriteLine("\n3. Strategy Pattern:");
            var paymentProcessor = new PaymentProcessor(new PayPalPayment());
            paymentProcessor.ProcessPayment(200m);


            // 4. Builder Pattern Demo
            Console.WriteLine("\n4. Builder Pattern:");
            var report = new ReportBuilder()
                .SetTitle("Monthly Sales Report")
                .SetContent("Sales increased by 20% in July")
                .Build();
            Console.WriteLine(report);


            // 5. Singleton Pattern Demo
            Console.WriteLine("\n5. Singleton Pattern:");
            var config1 = AppConfig.Instance;
            var config2 = AppConfig.Instance;
            Console.WriteLine($"Same instance? {config1 == config2}");

            Console.WriteLine("\n=== DEMO END ===");


            Console.ReadLine();

        }
    }
}


