
using DesignPatterns.Patterns.Behavioral.Memento.Memento;

namespace DesignPatterns.Patterns.Behavioral.Memento.CareTaker
{
    internal class History
    {
        private readonly Stack<DocumentMemento> _undoStack = new();
        private readonly Stack<DocumentMemento> _redoStack = new();

        private const int MaxHistorySize = 5;

        public void Backup(DocumentMemento memento)
        {
            if (_undoStack.Count >= MaxHistorySize)
            {
                Console.WriteLine("[History] Removing oldest history entry...");
                var tempStack = new Stack<DocumentMemento>(_undoStack);
                tempStack.Pop();
                _undoStack.Clear();

                foreach (var item in tempStack)
                    _undoStack.Push(item);
            }

            _undoStack.Push(memento);
            _redoStack.Clear(); // New change means redo stack resets

            Console.WriteLine($"[History] Saved state @ {memento.Timestamp.ToString("HH:mm:ss")}");
        }

        public DocumentMemento Undo()
        {
            if (_undoStack.Count == 0)
                throw new InvalidOperationException("Nothing to undo.");

            var memento = _undoStack.Pop();
            _redoStack.Push(memento);

            Console.WriteLine($"[History] Undo → Restoring @ {memento.Timestamp:HH:mm:ss}");
            return memento;
        }

        public DocumentMemento Redo()
        {
            if (_redoStack.Count == 0)
                throw new InvalidOperationException("Nothing to redo.");

            var memento = _redoStack.Pop();
            _undoStack.Push(memento);

            Console.WriteLine($"[History] Redo → Restoring @ {memento.Timestamp:HH:mm:ss}");
            return memento;
        }

    }
}
