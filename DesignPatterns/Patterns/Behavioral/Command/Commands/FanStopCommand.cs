

using DesignPatterns.Patterns.Behavioral.Command.Interfaces;
using DesignPatterns.Patterns.Behavioral.Command.Receivers;

namespace DesignPatterns.Patterns.Behavioral.Command.Commands
{
    internal class FanStopCommand : ICommand
    {
        private readonly Fan _fan;

        public FanStopCommand(Fan fan) 
        { 
            _fan = fan; 
        }

        public void Execute() => _fan.Stop();
        public void Undo() => _fan.Start();
    }
}
