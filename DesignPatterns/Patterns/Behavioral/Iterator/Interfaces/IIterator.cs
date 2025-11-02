
namespace DesignPatterns.Patterns.Behavioral.Iterator.Interfaces
{
    internal interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
