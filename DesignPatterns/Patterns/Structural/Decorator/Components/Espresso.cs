using DesignPatterns.Patterns.Structural.Composite.Decorator.Interfaces;


namespace DesignPatterns.Patterns.Structural.Composite.Decorator.Components
{
    internal class Espresso : ICoffee
    {
        public string GetDescription() => "Espresso";
        public double GetCost() => 2.50;
    }
}
