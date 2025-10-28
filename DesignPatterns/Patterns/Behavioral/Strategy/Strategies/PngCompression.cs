

using DesignPatterns.Patterns.Behavioral.Strategy.Interfaces;

namespace DesignPatterns.Patterns.Behavioral.Strategy.Strategies
{
    /// <summary>
    /// Concrete Strategy for compressing images using PNG format.
    /// </summary>
    internal class PngCompression : ICompressionStrategy
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"Compressing {fileName} using PNG compression...");
            Console.WriteLine("PNG compression complete. File size reduced by 40%.\n");
        }
    }
}
