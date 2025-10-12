using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.Products
{
    internal class DarkButton : IButton
    {
        public void Render()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[Dark Button] Sleek and modern style rendered.");
            Console.ResetColor();
        }
    }
}