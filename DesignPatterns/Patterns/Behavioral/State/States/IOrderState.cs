
using DesignPatterns.Patterns.Behavioral.State.Context;

namespace DesignPatterns.Patterns.Behavioral.State.States
{
    internal interface IOrderState
    {
        void Process(OrderContext context);
        void Ship(OrderContext context);
        void Cancel(OrderContext context);
    }
}
