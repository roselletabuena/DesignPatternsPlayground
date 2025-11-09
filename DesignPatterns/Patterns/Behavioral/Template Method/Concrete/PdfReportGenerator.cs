
using DesignPatterns.Patterns.Behavioral.Template_Method.Abstract;

namespace DesignPatterns.Patterns.Behavioral.Template_Method.Concrete
{
    internal class PdfReportGenerator : ReportGenerator
    {
        protected override void ExportReport()
        {
            Console.WriteLine("Exporting report as PDF file...");
        }
    }
}
