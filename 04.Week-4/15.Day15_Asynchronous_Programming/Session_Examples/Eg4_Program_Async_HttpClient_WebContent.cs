using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp43
{

    public class AsyncExample
    {
       public async Task<string> FetchWebContentAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {

               HttpResponseMessage response = await client.GetAsync(url);
               string content =  await response.Content.ReadAsStringAsync();
               return content; 
            };

        }
    }

    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting of the Program [Line-23]");

            AsyncExample asyncExample = new AsyncExample ();

            string url = "https://www.w3schools.com/angular/customers.php";
            string result  =  await asyncExample.FetchWebContentAsync(url);
            Console.WriteLine($"Web Content : \n{result}");

            Console.WriteLine("Reached End of the program [Line-30]");
            Console.ReadLine(); 
        }
    }
}
