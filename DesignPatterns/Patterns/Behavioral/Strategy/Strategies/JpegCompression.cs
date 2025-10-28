

using DesignPatterns.Patterns.Behavioral.Strategy.Interfaces;

namespace DesignPatterns.Patterns.Behavioral.Strategy.Strategies
{
    internal class JpegCompression : ICompressionStrategy
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"Compressing {fileName} using JPEG compression...");
            Console.WriteLine("JPEG compression complete. File size reduced by 60%.\n");
        }
    }
}
