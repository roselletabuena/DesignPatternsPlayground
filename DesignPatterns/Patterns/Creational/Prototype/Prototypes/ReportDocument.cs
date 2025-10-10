using System.Text.Json;

namespace DesignPatterns.Patterns.Creational.Prototype.Prototypes
{
    internal class ReportDocument : IDocumentPrototype
    {
        public string? Title { get; private set; }
        public string? Author { get; private set; }
        public string? Content { get; private set; }


        public ReportDocument(string title, string author, string content)
        {
            Title = title;
            Author = author;
            Content = content;
        }

        public IDocumentPrototype Clone()
        {
            return (IDocumentPrototype)this.MemberwiseClone();
        }

        public IDocumentPrototype DeepClone()
        {
            var json = JsonSerializer.Serialize(this);
            return JsonSerializer.Deserialize<ReportDocument>(json);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"[Report] Title {Title}, Author {Author}, Content {Content} ");
        }
    }
}
