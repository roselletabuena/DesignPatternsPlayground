
using DesignPatterns.Patterns.Behavioral.Visitor.Employees;

namespace DesignPatterns.Patterns.Behavioral.Visitor.Visitors
{
    internal class CsvExportVisitor : IEmployeeVisitor
    {
        public void Visit(FullTimeEmployee employee)
        {
            Console.WriteLine($"CSV Export: {employee.Name}, Full-Time, {employee.MonthlySalary}");
        }
        
        public void Visit(Contractor employee)
        {
            Console.WriteLine($"CSV Export: {employee.Name}, Contractor, {employee.HourlyRate}");
        }

    }
}
