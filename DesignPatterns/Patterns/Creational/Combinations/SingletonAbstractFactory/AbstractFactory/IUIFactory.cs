using DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.Products;

namespace DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.AbstractFactory
{
    internal interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
