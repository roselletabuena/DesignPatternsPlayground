

using DesignPatterns.Patterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Patterns.Behavioral.Visitor.Employees
{
    internal class FullTimeEmployee : IEmployee
    {
        public string Name { get; }
        public decimal MonthlySalary { get; }

        public FullTimeEmployee(string name, decimal monthySalary)
        {
            Name = name;
            MonthlySalary = monthySalary;
        }

        public void Accept(IEmployeeVisitor visitor) => visitor.Visit(this);
    }
}
