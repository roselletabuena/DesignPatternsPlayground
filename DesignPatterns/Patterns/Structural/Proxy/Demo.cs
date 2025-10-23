
using DesignPatterns.Patterns.Structural.Proxy.Interfaces;
using DesignPatterns.Patterns.Structural.Proxy.Models;

namespace DesignPatterns.Patterns.Structural.Proxy
{
    internal class Demo
    {

        public static void Run()
        {
            Console.WriteLine("==== Proxy Pattern Demo ====\n");

            IDocument doc1 = new ProxyDocument("ConfidentialReport.pdf", "Employee");
            IDocument doc2 = new ProxyDocument("FinancialStatement.pdf", "Admin");

            Console.WriteLine("\nAttempt 1: Employee trying to view confidential report...");
            doc1.Display();

            Console.WriteLine("\nAttempt 2: Admin viewing financial statement...");
            doc2.Display();

            Console.WriteLine("\nAttempt 3: Admin viewing same document again (should not reload)...");
            doc2.Display();
        }
    }
}
