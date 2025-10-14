using DesignPatterns.Patterns.Structural.Adapter.ExternalProviders;
using DesignPatterns.Patterns.Structural.Adapter.Interfaces;

namespace DesignPatterns.Patterns.Structural.Adapter.Adapters
{
    internal class CryptoAdapter : IPaymentProcessor
    {
        private readonly CryptoWalletAPI _cryptoWallet;
        private readonly string _walletAddress;

        public CryptoAdapter(string walletAddress)
        {
            _walletAddress = walletAddress;
            _cryptoWallet = new CryptoWalletAPI();
        }

        public void ProcessPayment(string accountIdentifier, decimal amount)
        {
            // Example: treat 1 BTC = $60,000 for demonstration
            decimal btcAmount = amount / 60000m;
            _cryptoWallet.TransferTokens(_walletAddress, btcAmount);
        }
    }
}
