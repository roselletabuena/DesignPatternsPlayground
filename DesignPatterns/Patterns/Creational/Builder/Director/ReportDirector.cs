using DesignPatterns.Patterns.Creational.Builder.Builders;
using DesignPatterns.Patterns.Creational.Builder.Products;

namespace DesignPatterns.Patterns.Creational.Builder.Director
{
    internal class ReportDirector
    {
        public  Report Construct(IReportBuilder builder, string title, string content)
        {
            builder.SetTitle(title);
            builder.SetHeader();
            builder.SetContent(content);
            builder.SetFooter();

            return builder.GetReport();
        }
    }
}
