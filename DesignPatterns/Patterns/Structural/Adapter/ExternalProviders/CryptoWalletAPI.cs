using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Structural.Adapter.ExternalProviders
{
    internal class CryptoWalletAPI
    {
        public void TransferTokens(string walletAddress, decimal tokens)
        {
            Console.WriteLine($"[Crypto] Transferred {tokens:F4} BTC to wallet: {walletAddress}");
        }
    }
}
