
// Before Refactor

namespace Console43
{
    public class InvoiceProcessor
    {
        public void ProcessInvoice(string type)
        {
            if (type == "PDF")
            {
                Console.WriteLine("Generating PDF Invoice...");
            }
            else if (type == "Excel")
            {
                Console.WriteLine("Generating Excel Invoice...");
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            InvoiceProcessor invoice = new InvoiceProcessor();
            invoice.ProcessInvoice("Excel");


            Console.ReadLine();
        }
    }


    

}