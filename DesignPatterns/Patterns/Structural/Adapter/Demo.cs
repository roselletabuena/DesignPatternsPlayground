using DesignPatterns.Patterns.Structural.Adapter.Adapters;
using DesignPatterns.Patterns.Structural.Adapter.Interfaces;

namespace DesignPatterns.Patterns.Structural.Adapter
{
    internal class Demo
    {
        public static void Run()
        {
            Console.WriteLine("=== Adapter Pattern Demo ===");

            var paymentProcessors = new List<IPaymentProcessor>
            {
                new PayPalAdapter("user@paypal.com"),
                new StripeAdapter("4242-4242-4242-4242"),
                new PayPalAdapter("1FzWLkD1a8xEw7fGzE7v6LqzZZBTCxyz")
            };

            string[] customerAccounts = { "CUST-001", "CUST-002", "CUST-003" };
            decimal[] amounts = { 120.75m, 89.99m, 1500.00m };

            for (int i = 0; i < paymentProcessors.Count; i++)
            {
                paymentProcessors[i].ProcessPayment(customerAccounts[i], amounts[i]);
            }

            Console.WriteLine("\nAll payments processed successfully!");
        }
    }
}
