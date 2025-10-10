

using System.Text.Json;

namespace DesignPatterns.Patterns.Creational.Prototype.Prototypes
{
    internal class InvoiceDocument: IDocumentPrototype
    {
       public string InvoiceNumber { get; private set; }
       public string CustomerName { get; private set; }
       
       public decimal Amount { get; private set; }

       public InvoiceDocument(string invoiceNumber, string customerName, decimal amount)
        {
            InvoiceNumber = invoiceNumber;
            CustomerName = customerName;
            Amount = amount;
        }

        public IDocumentPrototype Clone()
        {
            return (IDocumentPrototype)this.MemberwiseClone();
        }

        public IDocumentPrototype DeepClone()
        {
            var json = JsonSerializer.Serialize(this); 
            return JsonSerializer.Deserialize<InvoiceDocument>(json);

        }

        public void ShowInfo()
        {
            Console.WriteLine($"[INVOICE] #{InvoiceNumber} for {CustomerName} - ${Amount}");
        }
    }
}
