
namespace DesignPatterns.Patterns.Behavioral.Mediator
{
    internal abstract class User
    {
        protected IChatRoom chatRoom;
        public string Name { get; private set; }

        public User(IChatRoom chatRoom, string name)
        {
            this.chatRoom = chatRoom;
            this.Name = name;
        }

        public void Send(string message)
        {
            chatRoom.SendMessage(message, this);
        }

        public abstract void Receive(string message);
    }
}
