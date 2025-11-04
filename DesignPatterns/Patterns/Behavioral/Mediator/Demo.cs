
namespace DesignPatterns.Patterns.Behavioral.Mediator
{
    internal class Demo
    {
        public static void Run()
        {
            IChatRoom chatRoom = new ChatRoom();

            var alice = new ConcreteUser(chatRoom, "Alice");
            var bob = new ConcreteUser(chatRoom, "Bob");
            var charlie = new ConcreteUser(chatRoom, "Charlie");

            chatRoom.Register(alice);
            chatRoom.Register(bob);
            chatRoom.Register(charlie);

            Console.WriteLine("\n--- Communication Starts ---\n");


            alice.Send("Hey everyone, how's the C# design pattern project going?");

            Console.WriteLine();

            bob.Send("It's great! The Mediator pattern is really helping to decouple things.");

            Console.WriteLine();

            charlie.Send("I agree. Now users don't need direct references to each other.");

        }
    }
}
