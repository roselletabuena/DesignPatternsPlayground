

namespace DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.Products
{
    internal class LightButton : IButton
    {
        
        public void Render()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Light Button] Bright and clean style rendered.");
            Console.ResetColor();
        }
    }
}
