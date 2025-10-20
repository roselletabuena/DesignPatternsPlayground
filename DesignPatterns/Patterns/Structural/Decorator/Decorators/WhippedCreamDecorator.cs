using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Composite.Decorator.Decorators
{
    internal class WhippedCreamDecorator : CoffeeDecorator
    {
        public WhippedCreamDecorator(Interfaces.ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => _coffee.GetDescription() + ", Whipped Cream";
        public override double GetCost() => _coffee.GetCost() + 0.75;
    }
}
