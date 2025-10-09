using DesignPatterns.Patterns.Creational.Builder.Products;

namespace DesignPatterns.Patterns.Creational.Builder.Builders
{
    internal class PdfReportBuilder : IReportBuilder
    {
        Report _report = new();

        public void SetTitle(string title) => _report.Title = $"[PDF] {title}";
        public void SetHeader() => _report.Header = "PDF Report Header";
        public void SetContent(string content) => _report.Content = content;
        public void SetFooter() => _report.Footer = "PDF Report Footer";
        public Report GetReport() => _report;

    }
}
