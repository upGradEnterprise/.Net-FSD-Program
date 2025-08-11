public sealed class Logger
{
    // Instance is created immediately when the class is loaded
    private static readonly Logger instance = new Logger();

    // Private constructor prevents instantiation from outside
    private Logger()
    {
        Console.WriteLine("Logger instance created.");
    }

    // Public static method to access the single instance
    public static Logger GetInstance()
    {        
        return instance;        
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}


class Program
{
    static void Main()
    {
        Logger l1 = Logger.GetInstance();
        l1.Log("Application started.");

        Logger l2 = Logger.GetInstance();
        l2.Log("Performing some operations...");

        Logger l3 = Logger.GetInstance();
        l3.Log("Application ended.");

        Console.ReadLine();
    }
}
