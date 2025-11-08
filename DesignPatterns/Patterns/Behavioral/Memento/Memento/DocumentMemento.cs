
namespace DesignPatterns.Patterns.Behavioral.Memento.Memento
{
    internal class DocumentMemento
    {
        public string Content { get; }
        public DateTime Timestamp { get; }

        public DocumentMemento(string content)
        {
            Content = content;
            Timestamp = DateTime.Now;
        }
    }
}
