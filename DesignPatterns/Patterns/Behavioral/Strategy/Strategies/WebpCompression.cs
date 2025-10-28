using DesignPatterns.Patterns.Behavioral.Strategy.Interfaces;

namespace DesignPatterns.Patterns.Behavioral.Strategy.Strategies
{
    internal class WebpCompression : ICompressionStrategy
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"Compressing {fileName} using WEBP compression...");
            Console.WriteLine("WEBP compression complete. File size reduced by 70%.\n");
        }
    }
}
