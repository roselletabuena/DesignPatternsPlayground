using DesignPatterns.Patterns.Structural.Composite.Decorator.Interfaces;

namespace DesignPatterns.Patterns.Structural.Composite.Decorator.Components
{
    internal class Latte : ICoffee
    {
        public string GetDescription() => "Latte";
        public double GetCost() => 3.00;
    }
}
