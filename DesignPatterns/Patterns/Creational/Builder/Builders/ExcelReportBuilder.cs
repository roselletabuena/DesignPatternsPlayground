using DesignPatterns.Patterns.Creational.Builder.Products;

namespace DesignPatterns.Patterns.Creational.Builder.Builders
{
    internal class ExcelReportBuilder : IReportBuilder
    {
        Report _report = new();
        

        public void SetTitle(string title) => _report.Title = title;
        public void SetHeader() => _report.Header = "Excel Report Header";

        public void SetContent(string content) => _report.Content = content;

        public void SetFooter() => _report.Footer = "Excel Report Footer";

        public Report GetReport() => _report;
    }
}
