
namespace DesignPatterns.Patterns.Creational.AbstractFactory.Products
{
    internal class MacCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering a macOS-style checkbox.");
    }
}
