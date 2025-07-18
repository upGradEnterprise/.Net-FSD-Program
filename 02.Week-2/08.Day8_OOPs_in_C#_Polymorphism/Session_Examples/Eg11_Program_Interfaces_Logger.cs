namespace ConsoleApp39
{

    interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message);
        void LogWarning(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine($"[ERROR] : {message} - {DateTime.Now.ToString()}");
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"[INFO] : {message} - {DateTime.Now.ToString()}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"[WARNING] : {message} - {DateTime.Now.ToString()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();

            int x, y, z = 0;

            try
            {
                Console.WriteLine("Enter value for X: ");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter value for Y: ");
                y = int.Parse(Console.ReadLine());

                z = x / y;

                Console.WriteLine("Result  :  " + z);
                logger.LogInfo("Process completed successfully");
            }
            catch (Exception e)
            {
                //   Console.WriteLine("Exception Raised. Reason : " + e.Message);
                logger.LogError(e.Message);
            }

            Console.ReadLine();
        }
    }
}
