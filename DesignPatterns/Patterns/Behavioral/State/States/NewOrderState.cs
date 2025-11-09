

using DesignPatterns.Patterns.Behavioral.State.Context;

namespace DesignPatterns.Patterns.Behavioral.State.States
{
    internal class NewOrderState : IOrderState
    {
        public void Process(OrderContext context)
        {
            Console.WriteLine("Order is now being processed.");
            context.SetState(new ProcessingState());
        }

        public void Ship(OrderContext context)
        {
            Console.WriteLine("Cannot shop. Order must be processed first.");
        }

        public void Cancel(OrderContext context)
        {
            Console.WriteLine("Order canled successfully.");
            context.SetState(null);
        }
    }
}
