

namespace DesignPatterns.Patterns.Structural.Decorator.Decorators
{
    internal class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(Interfaces.ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => _coffee.GetDescription() + ", Milk";
        public override double GetCost() => _coffee.GetCost();
    }
}
