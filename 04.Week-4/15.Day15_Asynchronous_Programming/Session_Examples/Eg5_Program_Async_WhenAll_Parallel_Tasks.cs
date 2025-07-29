using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    public class AsyncExamples
    {

        public async Task<int> CalculateSumAsync(int a, int b)
        {
            await Task.Delay(1000); // Simulates async calculation
            return a + b;
        }

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
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
                return string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"IO error: {ex.Message}");
                throw; // Re-throw for unexpected IO errors
            }
        }


        // Example   Parallel async operations
        public async Task ProcessMultipleTasksAsync()
        {
            
                Task<int> task1 = CalculateSumAsync(5, 10);
                Task<int> task2 = CalculateSumAsync(20, 30);
                Task<string> task3 = ReadFileAsync("logs/structured-log20250728.txt");

                // Wait for all tasks to complete
                await Task.WhenAll(task1, task2, task3);

                Console.WriteLine($"Task 1 Result: {task1.Result}");
                Console.WriteLine($"Task 2 Result: {task2.Result}");
                Console.WriteLine($"File Content: {task3.Result}");            
        }
    }
    public class Program
    {
        // Example usage
        public static async Task Main()
        {
            var examples = new AsyncExamples();

            await examples.ProcessMultipleTasksAsync();

            Console.WriteLine("Reached End of the Program");
            Console.ReadLine();
        }
    }
}
