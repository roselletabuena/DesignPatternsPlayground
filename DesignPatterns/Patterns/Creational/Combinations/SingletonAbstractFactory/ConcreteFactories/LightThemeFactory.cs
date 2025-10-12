using DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.AbstractFactory;
using DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.Products;

namespace DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.ConcreteFactories
{
    internal class LightThemeFactory : IUIFactory
    {

        public IButton CreateButton() => new LightButton();
        public ICheckbox CreateCheckbox() => new LightCheckbox();
    }
}
