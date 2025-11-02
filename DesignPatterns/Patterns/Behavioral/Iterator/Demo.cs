
using DesignPatterns.Patterns.Behavioral.Iterator.Models;

namespace DesignPatterns.Patterns.Behavioral.Iterator
{
    internal class Demo
    {
        public static void Run()
        {
            Console.WriteLine("=== Iterator Pattern Demo ===\n");

            var alice = new User("Alice");
            var bob = new User("Bob");
            var charlie = new User("Charlie");
            var diana = new User("Diana");

            alice.AddFriend(bob);   
            alice.AddFriend(charlie);
            alice.AddFriend(diana);

            var network = new SocialNetwork(alice);
            var iterator = network.CreateIterator();

            Console.WriteLine($"[SocialNetwork] {alice.Name}'s friends:\n");

            while (iterator.HasNext())
            {
                var friend = iterator.Next();
                Console.WriteLine($" - {friend.Name}");
            }

            Console.WriteLine("\n[System] Traversal completed successfully.");
        }
    }
}
