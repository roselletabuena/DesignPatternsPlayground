
using DesignPatterns.Patterns.Behavioral.Strategy.Interfaces;

namespace DesignPatterns.Patterns.Behavioral.Strategy.Context
{
    /// <summary>
    /// The Context class uses a Strategy object to delegate image compression behavior.
    /// </summary>
    internal class ImageCompressor
    {
        private ICompressionStrategy _compressionStrategy;

        public void SetCompressionStrategy(ICompressionStrategy strategy)
        {
            _compressionStrategy = strategy; 
        }

        public void CompressImage(string fileName)
        {
            if (_compressionStrategy == null) {
                Console.WriteLine("No compression strategy selected. Please choose a format first.");
                return;
            }

            Console.WriteLine($"Starting compression for {fileName}...");
            _compressionStrategy.Compress(fileName);
        }

    }
}
