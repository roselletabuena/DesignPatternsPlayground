
namespace DesignPatterns.Patterns.Behavioral.Mediator
{
    internal class ConcreteUser : User
    {

        public ConcreteUser(IChatRoom chatRoom, string name) : base(chatRoom, name) { }

        public override void Receive(string message)
        {
            Console.WriteLine($"[{Name} received]: {message}");
        }

    }
}
