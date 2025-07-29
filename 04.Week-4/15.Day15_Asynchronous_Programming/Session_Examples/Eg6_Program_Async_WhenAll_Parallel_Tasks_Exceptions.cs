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
                throw; // Re-throw for unexpected IO errors
            }
        }


        // Example   Parallel async operations
        public async Task ProcessMultipleTasksAsync()
        {
            Task<int> task1 = CalculateSumAsync(5, 10);
            Task<int> task2 = CalculateSumAsync(20, 30);
            Task<string> task3 = ReadFileAsync("logs12/structured-log20250728.txt");

            try
            {
                // Wait for all tasks to complete
                await Task.WhenAll(task1, task2, task3);                 
            }
            catch
            {
                Console.WriteLine("Some tasks failed.");  
            }

            if (task1.IsFaulted)
                Console.WriteLine($"task-1 failed: {task1.Exception?.InnerException?.Message}");
            else
                Console.WriteLine($"Task-1 Result: {task1.Result}");


            if (task2.IsFaulted)
                Console.WriteLine($"task-2 failed: {task2.Exception?.InnerException?.Message}");
            else
                Console.WriteLine($"Task-2 Result: {task2.Result}");


            if (task3.IsFaulted)
                Console.WriteLine($"task-3 failed: {task3.Exception?.InnerException?.Message}");
            else
                Console.WriteLine($"Task-3 Result: {task3.Result}");



        }
    }
    public class Program
    {
        // Example usage
        public static async Task Main()
        {
            Console.WriteLine("Starting of the Program");

            var examples = new AsyncExamples();

            await examples.ProcessMultipleTasksAsync();

            Console.WriteLine("Reached End of the Program");
            Console.ReadLine();
        }
    }
}
