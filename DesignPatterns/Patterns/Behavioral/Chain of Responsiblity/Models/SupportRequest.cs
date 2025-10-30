

namespace DesignPatterns.Patterns.Behavioral.Chain_of_Responsiblity.Models
{
    internal class SupportRequest
    {
        public string CustomerName { get; }
        public string IssueDescription { get; }
        public int SeverityLevel {  get; }

        public SupportRequest(string customerName, string issueDescription, int severityLevel) 
        {
            CustomerName = customerName;
            IssueDescription = issueDescription;
            SeverityLevel = severityLevel;
        }
    }
}
