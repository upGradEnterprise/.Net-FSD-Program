
// After (Refactored using Strategy Pattern)

namespace Console43
{
    public interface IInvoiceGenerator
    {
        void Generate();
    }

    public class PdfInvoiceGenerator : IInvoiceGenerator
    {
        public void Generate() => Console.WriteLine("Generating PDF Invoice...");
    }

    public class ExcelInvoiceGenerator : IInvoiceGenerator
    {
        public void Generate() => Console.WriteLine("Generating Excel Invoice...");
    }

    public class InvoiceProcessor
    {
        private readonly IInvoiceGenerator _generator;
        public InvoiceProcessor(IInvoiceGenerator generator) => _generator = generator;
        public void ProcessInvoice() => _generator.Generate();
    }

    

    public class Program
    {
        static void Main(string[] args)
        {
            // Demo
            var pdfProcessor = new InvoiceProcessor(new PdfInvoiceGenerator());
            pdfProcessor.ProcessInvoice();

            var excelProcessor = new InvoiceProcessor(new ExcelInvoiceGenerator());
            excelProcessor.ProcessInvoice();


            Console.ReadLine();
        }
    }


    

}