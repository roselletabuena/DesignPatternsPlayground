
using DesignPatterns.Patterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Patterns.Behavioral.Visitor.Employees
{
    internal interface IEmployee
    {
        void Accept(IEmployeeVisitor visitor)
    }
}
