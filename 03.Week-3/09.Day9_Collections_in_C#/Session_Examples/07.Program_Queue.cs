using System.Collections.Generic;
 

namespace ConsoleApp39
{    
    class Program
    { 
            static void Main(string[] args)
            {

                Queue<string> printJobs = new Queue<string>();

                // Add jobs to the queue
                printJobs.Enqueue("Document1.pdf");
                printJobs.Enqueue("Report.docx");
                printJobs.Enqueue("Image.png");


                // Iterate the jobs in the queue
                int sno = 1;
                Console.WriteLine("Current Print Queue:");
                foreach (var job in printJobs)
                {
                    Console.WriteLine($"{sno} : {job}");
                    sno++;
                }


            Console.WriteLine("---------------------------");
            // Process jobs
            Console.WriteLine("\nProcessing Print Jobs:");
            while (printJobs.Count > 0)
            {
                string job = printJobs.Dequeue();
                Console.WriteLine($"Printing: {job}");
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("Print queue is empty.");


            Console.ReadLine();
            }
        }    
}
