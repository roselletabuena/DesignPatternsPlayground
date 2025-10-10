
namespace DesignPatterns.Patterns.Creational.Prototype.Prototypes
{
    internal interface IDocumentPrototype
    {
        IDocumentPrototype Clone();
        IDocumentPrototype DeepClone();
        void ShowInfo();
    }
}
