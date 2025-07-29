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




    }

    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting of the Program [Line-23]");

            AsyncExample asyncExample = new AsyncExample ();

            await asyncExample.PerformOperationAsync(1);

            await asyncExample.PerformOperationAsync(2);


            Console.WriteLine("Reached End of the program [Line-30]");
            Console.ReadLine(); 
        }
    }
}
