using DesignPatterns.Patterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.Factories
{
    internal class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ICheckbox CreateCheckbox() => new WindowsCheckbox();
    }
}
