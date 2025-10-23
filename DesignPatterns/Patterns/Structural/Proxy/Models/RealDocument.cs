

using DesignPatterns.Patterns.Structural.Proxy.Interfaces;

namespace DesignPatterns.Patterns.Structural.Proxy.Models
{
    /// <summary>
    /// The Proxy class controls access to the RealDocument and adds additional behavior (e.g., authorization).
    /// </summary>
    internal class RealDocument : IDocument
    {
        private readonly string _fileName;

        public RealDocument(string fileName)
        {
            _fileName = fileName;
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"[RealDocument] Loading '{_fileName}' from disk...");
        }

        public void Display()
        {
            Console.WriteLine($"[RealDocument] Displaying '{_fileName}'");
        }
    }
}
