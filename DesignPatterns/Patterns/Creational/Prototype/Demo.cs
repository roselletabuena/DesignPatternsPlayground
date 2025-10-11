using DesignPatterns.Patterns.Creational.Prototype.Prototypes;

namespace DesignPatterns.Patterns.Creational.Prototype
{
    internal class Demo
    {
        public static void Run()
        {
            Console.WriteLine("====== Prototype Pattern (Best Practice) ======\n");

            var registry = new PrototypeRegistry();

            registry.RegisterPrototype("report", new ReportDocument("Annual Report", "Alice", "Company performance summary..."));
            registry.RegisterPrototype("invoice", new InvoiceDocument("INV-001", "John Doe", 250.75m));

            var reportCopy = (ReportDocument)registry.GetClone("report");
            var invoiceDeepCopy = (InvoiceDocument)registry.GetClone("invoice", deep: true);

            reportCopy.GetType().GetProperty("Title")?.SetValue(reportCopy, "Annual Report - Copy");
            invoiceDeepCopy.GetType().GetProperty("CustomerName")?.SetValue(invoiceDeepCopy, "Jane Smith");

            registry.GetClone("report").ShowInfo();
            reportCopy.ShowInfo();

            registry.GetClone("invoice").ShowInfo();
            invoiceDeepCopy.ShowInfo();

        }

    }
}
