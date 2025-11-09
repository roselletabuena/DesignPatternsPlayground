
using DesignPatterns.Patterns.Behavioral.Template_Method.Abstract;

namespace DesignPatterns.Patterns.Behavioral.Template_Method.Concrete
{
    internal class CsvReportGenerator : ReportGenerator
    {
        protected override void ExportReport()
        {
           Console.WriteLine("Exporting report as CSV file...");
        }
    }
}
