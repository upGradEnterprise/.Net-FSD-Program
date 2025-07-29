using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp43
{

    public class AsyncExample
    {
        public async Task<string> ReadFileAsync(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string content = await reader.ReadToEndAsync();
                    return content;
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine($"File Not Found. {ex.Message}");
                return string.Empty;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IO Error. {ex.Message}");
                throw;  
            }
        }

    }

    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting of the Program [Line-23]");

            AsyncExample asyncExample = new AsyncExample ();

            try
            {
                string content = await asyncExample.ReadFileAsync("logs/structured-log20250728.txt");
                Console.WriteLine($"File content: {content}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Main Thread] Error occured in async operation: {ex.Message}");
            }


            Console.WriteLine("Reached End of the program [Line-30]");
            Console.ReadLine(); 
        }
    }
}
