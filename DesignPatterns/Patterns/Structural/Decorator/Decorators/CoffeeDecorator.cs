
using DesignPatterns.Patterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Patterns.Structural.Decorator.Decorators
{
    internal abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee _coffee;

        protected CoffeeDecorator(ICoffee cofee)
        {
            _coffee = cofee;
        }

        public virtual string GetDescription() => _coffee.GetDescription();
        public virtual double GetCost () => _coffee.GetCost();
    }
}
