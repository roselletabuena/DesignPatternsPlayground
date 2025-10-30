
using DesignPatterns.Patterns.Behavioral.Command.Interfaces;
using DesignPatterns.Patterns.Behavioral.Command.Receivers;

namespace DesignPatterns.Patterns.Behavioral.Command.Commands
{
    internal class FanStartCommand : ICommand
    {
        private readonly Fan _fan;

        public FanStartCommand(Fan fan) 
        { 
            _fan = fan;
        }

        public void Execute() => _fan.Start();
        public void Undo() => _fan.Stop();
    }
}
