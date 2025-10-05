using DesignPatterns.Patterns.Creational.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.AbstractFactory.Factories
{
    internal interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
