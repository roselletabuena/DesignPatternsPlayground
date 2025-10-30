using DesignPatterns.Patterns.Behavioral.Command.Interfaces;
using DesignPatterns.Patterns.Behavioral.Command.Receivers;

namespace DesignPatterns.Patterns.Behavioral.Command.Commands
{
    internal class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light) 
        { 
            _light = light;
        }

        public void Execute() => _light.Off();
        public void Undo() => _light.On();
    }
}
