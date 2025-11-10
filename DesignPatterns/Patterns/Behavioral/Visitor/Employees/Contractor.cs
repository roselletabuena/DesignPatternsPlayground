

using DesignPatterns.Patterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Patterns.Behavioral.Visitor.Employees
{
    internal class Contractor : IEmployee
    {
        public string Name { get; }
        public decimal HourlyRate { get; }

        public Contractor(string name, decimal hourlyRate)
        {
            Name = name;
            HourlyRate = hourlyRate;
        }

        public void Accept(IEmployeeVisitor visitor) => visitor.Visit(this);
    }
}
