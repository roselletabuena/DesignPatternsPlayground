
namespace DesignPatterns.Patterns.Structural.Composite.Interfaces
{
    internal interface IFileSystemItem
    {
        string Name { get; }
        long GetSize();
        void Display(string indent = "");
    }
}
