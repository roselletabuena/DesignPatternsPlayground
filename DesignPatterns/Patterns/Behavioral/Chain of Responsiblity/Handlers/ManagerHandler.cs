using DesignPatterns.Patterns.Behavioral.Chain_of_Responsiblity.Interfaces;
using DesignPatterns.Patterns.Behavioral.Chain_of_Responsiblity.Models;

namespace DesignPatterns.Patterns.Behavioral.Chain_of_Responsiblity.Handlers
{
    internal class ManagerHandler : ISupportHandler
    {

        private ISupportHandler? _next;

        public ISupportHandler SetNext(ISupportHandler next)
        {
            _next = next; 
            return next; 
        }

        public void Handle(SupportRequest request)
        {

            if(request.SeverityLevel >= 3)
            {
                Console.WriteLine($"[Manager] CRITICAL issue resolved for {request.CustomerName}: {request.IssueDescription}");
            } 
            else
            {
                Console.WriteLine($"[Manager] Issue '{request.IssueDescription}' did not match any handler.");
            }
        }
    }
}
