using DesignPatterns.Patterns.Behavioral.Memento.Memento;

namespace DesignPatterns.Patterns.Behavioral.Memento.Originator
{
    internal class Document
    {
        public string Content { get; private set; } = String.Empty;

        public void Write(string text)
        {
            Content += text;
        }

        public DocumentMemento Save()
        {
            return new DocumentMemento(Content);
        }

        public void Restore(DocumentMemento memento)
        {
            Content = memento.Content; 
        }
    }
}
