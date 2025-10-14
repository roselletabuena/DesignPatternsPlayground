
using DesignPatterns.Patterns.Structural.Adapter.ExternalProviders;
using DesignPatterns.Patterns.Structural.Adapter.Interfaces;

namespace DesignPatterns.Patterns.Structural.Adapter.Adapters
{
    internal class StripeAdapter : IPaymentProcessor
    {
        private readonly StripeService _stripeService;
        private readonly string _cardNumber;
        
        public StripeAdapter(string cardNumber)
        {
            _cardNumber = cardNumber;
            _stripeService = new StripeService();
        }

        public void ProcessPayment(string accountIdentifier, decimal amount)
        {
            _stripeService.SendPayment(amount, _cardNumber);
        }
    }
}
