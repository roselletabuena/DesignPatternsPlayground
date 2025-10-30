using DesignPatterns.Patterns.Behavioral.Command.Interfaces;

namespace DesignPatterns.Patterns.Behavioral.Command.Invoker
{

    /// <summary>
    /// The Invoker class holds commands and can execute or undo them.
    /// </summary>
    internal class RemoteControl
    {

        private ICommand? _command;
        private ICommand? _lastCommand;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void PressButton()
        {
            if (_command == null)
            {
                Console.WriteLine("[Remote] No command assigned.");
                return;
            }

            _command.Execute();
            _lastCommand = _command;
        }

        public void PressUndo()
        { 
            if (_lastCommand == null)
            {
                Console.WriteLine("[Remote] Nothing to undo.");
                return;
            }

            Console.WriteLine("[Remote] Undoing last comand...");
            _lastCommand.Undo();
            _lastCommand = null;

        }

    }
}
