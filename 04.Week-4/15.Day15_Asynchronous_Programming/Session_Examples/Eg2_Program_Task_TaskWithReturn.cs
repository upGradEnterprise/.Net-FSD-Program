using System.Threading.Tasks;

namespace ConsoleApp43
{

    public class AsyncExample
    {
        // Basic Task class usage without return value
        public async Task PerformOperationAsync(int id)
        {
            Console.WriteLine($"[Operation Id : {id} ] Starting long-running operation");

            await Task.Delay(2000);

            Console.WriteLine($"[Operation Id : {id} ] End of Long-running operation");
        }

        // Task<T> usage with return value
        public async Task<int> CalculateSumAsync(int a, int b)
        {
            await Task.Delay(1000); // Simulates async calculation
            return a + b;
        }


    }

    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting of the Program [Line-23]");

            AsyncExample asyncExample = new AsyncExample ();

            await asyncExample.PerformOperationAsync(1);

            await asyncExample.PerformOperationAsync(2);

            Console.WriteLine("--------------------------");


            // Task<T>
            int sum = await asyncExample.CalculateSumAsync(10, 20);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine("--------------------------------");



            Console.WriteLine("Reached End of the program [Line-30]");
            Console.ReadLine(); 
        }
    }
}
