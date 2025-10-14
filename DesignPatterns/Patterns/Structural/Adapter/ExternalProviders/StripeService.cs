using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Adapter.ExternalProviders
{
    internal class StripeService
    {
        public void SendPayment(decimal value, string cardNumber)
        {
            Console.WriteLine($"[Stripe] Charged ${value:F2} to card: {cardNumber}");
        }
    }
}
