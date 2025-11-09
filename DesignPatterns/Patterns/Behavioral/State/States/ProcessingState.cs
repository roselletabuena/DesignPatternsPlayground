using DesignPatterns.Patterns.Behavioral.State.Context;

namespace DesignPatterns.Patterns.Behavioral.State.States
{
    internal class ProcessingState : IOrderState
    {

        public void Process(OrderContext context)
        {
            Console.WriteLine("Order is already being processed.");
        }

        public void Ship(OrderContext context)
        {
            Console.WriteLine("Order has been shipped");
            context.SetState(new ShippedState());
        }

        public void Cancel(OrderContext context)
        {
            Console.WriteLine("Cannot cancel. Order is already being processed.");

        }
    }
}
