using DesignPatterns.Patterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.Factories
{
    internal class MacUIFactory : IUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }
}
