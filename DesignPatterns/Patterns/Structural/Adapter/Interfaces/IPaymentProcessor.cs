using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Adapter.Interfaces
{
    internal interface IPaymentProcessor
    {
        void ProcessPayment(string accountNumber, decimal amount);
    }
}
