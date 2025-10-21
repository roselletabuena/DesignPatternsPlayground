using DesignPatterns.Patterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Patterns.Structural.Decorator.Components
{
    internal class Latte : ICoffee
    {
        public string GetDescription() => "Latte";
        public double GetCost() => 3.00;
    }
}
