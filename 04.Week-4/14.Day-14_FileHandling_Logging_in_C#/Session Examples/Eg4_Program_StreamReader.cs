using System.IO;

namespace ConsoleApp41
{
    using System;
    using System.IO;

    class ActivityLogger
    {
        static void Main()
        {
           

            string logPath = Path.Combine("Logs", "activity_log.txt");
            using (StreamReader reader = new StreamReader(logPath))
            {
                while (reader.EndOfStream == false)
                {
                    Console.WriteLine(reader.ReadLine());                   
                }
            }

          
            Console.ReadLine(); 
        }
    }
}