

namespace DesignPatterns.Patterns.Behavioral.Mediator
{
    internal class ChatRoom : IChatRoom
    {
        private List<User> users = new();

        public void Register(User user)
        {
            Console.WriteLine($"{user.Name} has joined the chat room.");
            users.Add(user);
        }

        public void SendMessage(string message, User sendingUser)
        {

            string time = DateTime.Now.ToShortTimeString();
            string formattedMessage = $"({time}) {sendingUser.Name}: {message}";

            // Send the message to all other users (Colleagues)
            foreach (var user in users)
            {
                // Don't send the message back to the sender
                if (user != sendingUser)
                {
                    user.Receive(formattedMessage);
                }
            }
        }
    }
}
