using System.IO;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            string strFileName = "TestFile.txt";
            FileInfo fileInfo = new FileInfo(strFileName);

            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Length);
            Console.WriteLine(fileInfo.CreationTime);   
            Console.WriteLine(fileInfo.LastWriteTime);
            Console.WriteLine(fileInfo.DirectoryName);
            Console.WriteLine(fileInfo.Extension);

            Console.ReadLine();
        }
    }
}