namespace DesignPatterns.Patterns.Structural.Adapter.ExternalProviders
{
    internal class PayPalGateway
    {

        // Third-party or legacy API (incompatible)
        public void MakePayment(string email, double total)
        {
            Console.WriteLine($"[PayPal] Payment of ${total} sent to {email}");
        }
    }
}
