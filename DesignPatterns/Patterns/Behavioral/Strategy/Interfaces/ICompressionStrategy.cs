
namespace DesignPatterns.Patterns.Behavioral.Strategy.Interfaces
{
    /// <summary>
    /// The Strategy interface declares a common method for image compression algorithms.
    /// </summary>
    internal interface ICompressionStrategy
    {
        void Compress(string fileName);
    }
}
