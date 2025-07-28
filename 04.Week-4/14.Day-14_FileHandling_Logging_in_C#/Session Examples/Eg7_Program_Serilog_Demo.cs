using Serilog;
using Serilog.Core;

namespace ConsoleApp42
{   
        class Program
        {

            public static ILogger ConfigureSerilog()
            {
                Log.Logger = new LoggerConfiguration()
                        .MinimumLevel.Debug()
                        .WriteTo.Console()
                        .WriteTo.File("logs/structured-log.txt", rollingInterval: RollingInterval.Day)
                        .Enrich.WithProperty("Application", "StructuredLoggingDemoApp")
                        .CreateLogger();

                return Log.Logger;
            }
            static void Main(string[] args)
            {
                // Set up Serilog with console and file sinks
                Log.Logger = ConfigureSerilog();

                try
                {
                    Log.Information("Application started");

                    int userId = 42;
                    int orderId = 1001;
                    string product = "Gaming Laptop";
                    decimal price = 1299.99m;

                    Log.Information("User {UserId} placed order {OrderId} for {Product} at ${Price}",
                        userId, orderId, product, price);

                    SimulatePayment(userId, orderId, price);

                    Log.Warning("Order {OrderId} might be delayed due to high demand", orderId);

                    throw new InvalidOperationException("Payment processing failed due to timeout.");
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "An unexpected error occurred while processing order");
                }
                finally
                {
                    Log.Information("Application ended");
                    Log.CloseAndFlush();
                }


            Console.ReadLine();
            }

            static void SimulatePayment(int userId, int orderId, decimal amount)
            {
                Log.Debug("Initiating payment for OrderId: {OrderId}, Amount: ${Amount}", orderId, amount);
                // Simulate delay
                System.Threading.Thread.Sleep(1000);
                Log.Information("Payment for OrderId {OrderId} by UserId {UserId} completed", orderId, userId);
            }
        }
 

}
