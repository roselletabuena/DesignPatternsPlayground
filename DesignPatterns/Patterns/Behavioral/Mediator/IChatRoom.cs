

namespace DesignPatterns.Patterns.Behavioral.Mediator
{
    internal interface IChatRoom
    {
        void SendMessage(string message, User user);
        void Register(User user);

    }
}
