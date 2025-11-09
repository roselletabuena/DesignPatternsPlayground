
namespace DesignPatterns.Patterns.Behavioral.Template_Method.Abstract
{
    internal abstract class ReportGenerator
    {
        public void Generate()
        {
            ValidateData();
            PrepareData();
            ExportReport();

            Console.WriteLine("Report generation completed.\n");
        }

        protected void ValidateData()
        {
            Console.WriteLine("Validating input data...");
        }

        protected void PrepareData()
        {
            Console.WriteLine("Formatting data and applying filters...");
        }

        protected abstract void ExportReport();
    }
}
