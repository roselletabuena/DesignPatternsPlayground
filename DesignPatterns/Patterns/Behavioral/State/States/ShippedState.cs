
using DesignPatterns.Patterns.Behavioral.State.Context;

namespace DesignPatterns.Patterns.Behavioral.State.States
{
    internal class ShippedState : IOrderState
    {
        public void Process(OrderContext context)
        {
            Console.WriteLine("Cannot proceses. Order already shipped");
        }

        public void Ship(OrderContext context)
        {
            Console.WriteLine("Order already shipped.");
        }

        public void Cancel(OrderContext context)
        {
            Console.WriteLine("Cannot cancel. The order has already shipped.");
        }
    }
}
