
using DesignPatterns.Patterns.Behavioral.Template_Method.Concrete;

namespace DesignPatterns.Patterns.Behavioral.Template_Method
{
    internal class Demo
    {
        public static void Run()
        {
            Console.WriteLine("=== Template Method Pattern Demo ===\n");

            var pdfReport = new PdfReportGenerator();
            pdfReport.Generate();

            var excelReport = new ExcelReportGenerator();
            excelReport.Generate();

            var csvReport = new CsvReportGenerator();
            csvReport.Generate();
        }

    }
}
