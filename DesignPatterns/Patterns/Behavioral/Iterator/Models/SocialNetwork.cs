
using DesignPatterns.Patterns.Behavioral.Iterator.Interfaces;
using DesignPatterns.Patterns.Behavioral.Iterator.Iterators;

namespace DesignPatterns.Patterns.Behavioral.Iterator.Models
{
    internal class SocialNetwork : IAggregate<User>
    {
        private readonly User _rootUser;

        public SocialNetwork(User rootUser)
        {
            _rootUser = rootUser;
        }

        public IIterator<User> CreateIterator()
        {
            return new FriendsIterator(_rootUser);
        }
    }
}
