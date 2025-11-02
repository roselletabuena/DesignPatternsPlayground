using DesignPatterns.Patterns.Behavioral.Iterator.Interfaces;
using DesignPatterns.Patterns.Behavioral.Iterator.Models;

namespace DesignPatterns.Patterns.Behavioral.Iterator.Iterators
{
    internal class FriendsIterator : IIterator<User>
    {
        private readonly List<User> _friends;
        private int _position = 0;

        public FriendsIterator(User user)
        {
            _friends = user.Friends;
        }

        public bool HasNext()
        {
            return _position < _friends.Count;  
        }

        public User Next()
        {
            return _friends[_position++];
        }

    }
}
