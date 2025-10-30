
using DesignPatterns.Patterns.Behavioral.Command.Interfaces;
using DesignPatterns.Patterns.Behavioral.Command.Receivers;

namespace DesignPatterns.Patterns.Behavioral.Command.Commands
{
    internal class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute() => _light.On();

        public void Undo() => _light.Off();
    }
}
