
namespace DesignPatterns.Patterns.Behavioral.Iterator.Interfaces
{
    internal interface IAggregate<T>
    {
        IIterator<T> CreateIterator();

    }
}
