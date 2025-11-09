

using DesignPatterns.Patterns.Behavioral.State.Context;

namespace DesignPatterns.Patterns.Behavioral.State
{
    internal class Demo
    {
      public static void Run()
      {
           Console.WriteLine("=== State Pattern Demo (Order Workflow) ===\n");

            var order = new OrderContext();

            order.ProcessOrder();
            order.ShipOrder();
            order.CancelOrder();
      }
    }
}
