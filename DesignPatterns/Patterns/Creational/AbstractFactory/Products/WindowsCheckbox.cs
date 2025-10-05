

namespace DesignPatterns.Patterns.Creational.AbstractFactory.Products
{
    internal class WindowsCheckbox : ICheckbox
    {
        public void Render () => Console.WriteLine("Rendering a Windows-style checkbox.");
    }
}
