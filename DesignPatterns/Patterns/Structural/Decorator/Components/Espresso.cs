using DesignPatterns.Patterns.Structural.Decorator.Interfaces;


namespace DesignPatterns.Patterns.Structural.Decorator.Components
{
    internal class Espresso : ICoffee
    {
        public string GetDescription() => "Espresso";
        public double GetCost() => 2.50;
    }
}
