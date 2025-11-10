
using DesignPatterns.Patterns.Behavioral.Visitor.Employees;

namespace DesignPatterns.Patterns.Behavioral.Visitor.Visitors
{
    internal interface IEmployeeVisitor
    {
        void Visit(FullTimeEmployee employee);
        void Visit(Contractor employee);
    }
}
