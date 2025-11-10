using DesignPatterns.Patterns.Behavioral.Visitor.Employees;
using System.Text.Json;

namespace DesignPatterns.Patterns.Behavioral.Visitor.Visitors
{
    internal class JsonExportVisitor : IEmployeeVisitor
    {

        public void Visit(FullTimeEmployee employee)
        {
            var json = JsonSerializer.Serialize(new
            {
                employee.Name,
                Type = "Full-Time",
                Salary = employee.MonthlySalary
            });

            Console.WriteLine($"JSON Export: {json}");
        }

        public void Visit(Contractor employee)
        {
            var json = JsonSerializer.Serialize(new
            {
                employee.Name,
                Type = "Contractor",
                Rate = employee.HourlyRate
            });

            Console.WriteLine($"JSON Export: {json}");
        }

    }
}
