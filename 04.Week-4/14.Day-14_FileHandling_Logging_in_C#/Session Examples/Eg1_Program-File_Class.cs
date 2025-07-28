using System.IO;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            string strData = $"Message prepared at {DateTime.Now}\n";

            //   File.WriteAllText("TestFile.txt", strData);
            File.AppendAllText("TestFile.txt", strData);


            Console.WriteLine("Message is written on File");

            Console.ReadLine();
        }
    }
}