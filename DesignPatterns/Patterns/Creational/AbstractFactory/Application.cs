

using DesignPatterns.Patterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Patterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
    internal class Application
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;

        public Application(IUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();  
        }

        public void RenderUI()
        {
            _button.Paint();
            _checkbox.Render();
        }
    }
}
