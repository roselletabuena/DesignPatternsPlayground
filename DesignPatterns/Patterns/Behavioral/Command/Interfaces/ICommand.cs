
namespace DesignPatterns.Patterns.Behavioral.Command.Interfaces
{

    /// <summary>
    /// The Command interface declares methods for executing and undoing actions.
    /// </summary>
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
