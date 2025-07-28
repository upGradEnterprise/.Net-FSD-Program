using System.IO;

namespace ConsoleApp41
{
    using System;
    using System.IO;

    class ActivityLogger
    {
        static void Main()
        {
            if(Directory.Exists("Logs") == false)
            {
                Directory.CreateDirectory("Logs");
            }
            

            string logPath = Path.Combine("Logs", "activity_log.txt");
            using (StreamWriter sw = new StreamWriter(logPath, true))
            {
                sw.WriteLine($"[INFO] Message recorded in Log file at :  {DateTime.Now}");
            }

            Console.WriteLine("Activity logged.");
            Console.ReadLine(); 
        }
    }
}