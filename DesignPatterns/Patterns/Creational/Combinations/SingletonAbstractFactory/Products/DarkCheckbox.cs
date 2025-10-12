using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Creational.Combinations.SingletonAbstractFactory.Products
{
    internal class DarkCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[Dark Checkbox] Compact and elegant design rendered.");
            Console.ResetColor();
        }
    }
}
