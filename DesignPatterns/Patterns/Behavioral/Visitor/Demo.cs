
using DesignPatterns.Patterns.Behavioral.Visitor.Employees;
using DesignPatterns.Patterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Patterns.Behavioral.Visitor
{
    internal class Demo
    {
        public static void Run()
        {
            var employees = new List<IEmployee>
            { new FullTimeEmployee("Alice", 75000),
              new Contractor("Bob", 500)
            };

            IEmployeeVisitor csvVisitor = new CsvExportVisitor();
            IEmployeeVisitor jsonVisitor = new JsonExportVisitor();

            Console.WriteLine("=== CSV Export ===");
            employees.ForEach(e => e.Accept(csvVisitor));

            Console.WriteLine("\n=== JSON Export ===");
            employees.ForEach(e => e.Accept(jsonVisitor));
        }
    }
}
