
namespace DesignPatterns.Patterns.Behavioral.Iterator.Models
{
    internal class User
    {
        public string Name { get; }
        public List<User> Friends { get; }

        public User(string name)
        {
            Name = name;
            Friends = new List<User>();
        }

        public void AddFriend(User friend)
        {
            if(!Friends.Contains(friend))
                Friends.Add(friend);
        }
    }
}
