

using DesignPatterns.Patterns.Behavioral.Chain_of_Responsiblity.Models;

namespace DesignPatterns.Patterns.Behavioral.Chain_of_Responsiblity.Interfaces
{
    internal interface ISupportHandler
    {
        ISupportHandler SetNext(ISupportHandler next);
        void Handle(SupportRequest request);
    }
}
