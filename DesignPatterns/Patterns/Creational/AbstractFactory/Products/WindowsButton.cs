
namespace DesignPatterns.Patterns.Creational.AbstractFactory.Products
{
    internal class WindowsButton : IButton
    {
        public void Paint() => Console.WriteLine("Rendering a Windows-style checkbox.");
    }
}
