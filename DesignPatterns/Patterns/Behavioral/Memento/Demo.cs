
using DesignPatterns.Patterns.Behavioral.Memento.CareTaker;
using DesignPatterns.Patterns.Behavioral.Memento.Originator;


namespace DesignPatterns.Patterns.Behavioral.Memento
{
    internal class Demo
    {
        public static void Run()
        {
            Console.WriteLine("=== Enhanced Memento Pattern Demo ===\n");

            var document = new Document();
            var history = new History();

            document.Write("Hello");
            history.Backup(document.Save());

            document.Write(", world!");
            history.Backup(document.Save());

            document.Write(" Enchaned version with Undo/Redo.");
            history.Backup(document.Save());

            Console.WriteLine($"\n Current: {document.Content}");

            document.Restore(history.Undo());
            Console.WriteLine($"After Undo 1: {document.Content}");
            document.Restore(history.Undo());
            Console.WriteLine($"After Undo 2: {document.Content}");

            document.Restore(history.Redo());
            Console.WriteLine($"After Redo: {document.Content}");

        }
    }
}
