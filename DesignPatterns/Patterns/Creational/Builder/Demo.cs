
using DesignPatterns.Patterns.Creational.Builder.Builders;
using DesignPatterns.Patterns.Creational.Builder.Director;
using DesignPatterns.Patterns.Creational.Builder.Products;

namespace DesignPatterns.Patterns.Creational.Builder
{
    internal class Demo
    {
        public static void Run()
        {
            var director = new ReportDirector();

            var pdfBuilder = new PdfReportBuilder();
            var pdfReport = director.Construct(pdfBuilder, "Sales Report", "This is the sales data for Q1.");
            Console.WriteLine(pdfReport);

            Console.WriteLine();

            var excelBuilder = new ExcelReportBuilder();
            var excelReport = director.Construct(excelBuilder, "Inventory Report", "This is the inventory data for April");
            Console.WriteLine(excelReport);

        }
    }
}
