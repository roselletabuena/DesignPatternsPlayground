using DesignPatterns.Patterns.Structural.Composite.Interfaces;

namespace DesignPatterns.Patterns.Structural.Composite.Components
{
    internal class FileItem : IFileSystemItem
    {
        public string Name { get; }
        private readonly long _size;

        public FileItem(string name, long size)
        {
            Name = name; 
            _size = size; 
        }

        public long GetSize() => _size;

        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}- {Name} ({_size} KB)");
        }
    }
}
