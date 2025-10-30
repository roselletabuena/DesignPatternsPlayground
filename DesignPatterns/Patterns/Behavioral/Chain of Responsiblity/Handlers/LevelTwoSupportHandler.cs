using DesignPatterns.Patterns.Behavioral.Chain_of_Responsiblity.Interfaces;
using DesignPatterns.Patterns.Behavioral.Chain_of_Responsiblity.Models;

namespace DesignPatterns.Patterns.Behavioral.Chain_of_Responsiblity.Handlers
{
    internal class LevelTwoSupportHandler : ISupportHandler
    {
        private ISupportHandler? _next;

        public ISupportHandler SetNext(ISupportHandler next)
        {
            _next = next;
            return next;
        }


        public void Handle(SupportRequest request)
        {
            if(request.SeverityLevel == 2)
            {
                Console.WriteLine($"[Level 2 Support] Resolved issue for {request.CustomerName}: {request.IssueDescription}");
            } else
            {
                Console.WriteLine($"[Level 2 Support] Cannot handle '{request.IssueDescription}'. Escalating...");
                _next?.Handle(request);
            }
        }

    }
}
