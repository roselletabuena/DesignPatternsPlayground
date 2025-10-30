
using DesignPatterns.Patterns.Behavioral.Command.Commands;
using DesignPatterns.Patterns.Behavioral.Command.Invoker;
using DesignPatterns.Patterns.Behavioral.Command.Receivers;

namespace DesignPatterns.Patterns.Behavioral.Command
{
    internal class Demo
    {
        public static void Run()
        {
            Console.WriteLine("=== Conmmand Pattern Demo ===\n");

            var light = new Light();
            var fan = new Fan();

            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);
            var fanStart = new FanStartCommand(fan);
            var fanStop = new FanStopCommand(fan);

            var remote = new RemoteControl();

            remote.SetCommand(lightOn);
            remote.PressButton();


            remote.SetCommand(fanStart);
            remote.PressButton();

            remote.PressUndo();

            remote.SetCommand(lightOff);
            remote.PressButton();

            remote.PressUndo();
        }
    }
}
