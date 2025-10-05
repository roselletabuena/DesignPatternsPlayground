
namespace DesignPatterns.Patterns.Creational.AbstractFactory.Products
{
    internal class MacButton : IButton
    {
        public void Paint() => Console.WriteLine("Rendering a macOS-style button.");
    }
}
