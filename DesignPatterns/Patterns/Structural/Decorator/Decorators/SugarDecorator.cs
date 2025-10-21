
namespace DesignPatterns.Patterns.Structural.Decorator.Decorators
{
    internal class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(Interfaces.ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => _coffee.GetDescription() + ", Sugar";
        public override double GetCost() => _coffee.GetCost();

    }
}
