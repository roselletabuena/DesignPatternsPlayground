using DesignPatterns.Patterns.Structural.Adapter.ExternalProviders;
using DesignPatterns.Patterns.Structural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Adapter.Adapters
{
    internal class PayPalAdapter : IPaymentProcessor
    {
        private readonly PayPalGateway _payPalGateway;
        private readonly string _email;

        public PayPalAdapter(string email)
        {
            _email = email;
            _payPalGateway = new PayPalGateway();
        }

        public void ProcessPayment(string accountNumber, decimal amount)
        {
            _payPalGateway.MakePayment(_email, (double)amount);
        }

    }
}
