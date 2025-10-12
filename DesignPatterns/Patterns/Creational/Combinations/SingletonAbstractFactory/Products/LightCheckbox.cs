

namespace DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.Products
{
    internal class LightCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Light Checkbox] Soft and minimal design rendered.");
            Console.ResetColor();
        }
    }
}
