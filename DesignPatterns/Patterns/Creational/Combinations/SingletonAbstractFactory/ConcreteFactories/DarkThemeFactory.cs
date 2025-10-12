
using DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.AbstractFactory;
using DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.Products;

namespace DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.ConcreteFactories
{
    internal class DarkThemeFactory : IUIFactory
    {
        public IButton CreateButton() => new DarkButton();
        public ICheckbox CreateCheckbox() => new DarkCheckbox();

    }
}
