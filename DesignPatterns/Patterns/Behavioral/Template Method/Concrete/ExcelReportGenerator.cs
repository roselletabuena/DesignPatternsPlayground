

using DesignPatterns.Patterns.Behavioral.Template_Method.Abstract;

namespace DesignPatterns.Patterns.Behavioral.Template_Method.Concrete
{
    internal class ExcelReportGenerator : ReportGenerator
    {

        protected override void ExportReport()
        {
            Console.WriteLine("Exporting report as Excel (.xlsx) file...");
        }
    }
}
