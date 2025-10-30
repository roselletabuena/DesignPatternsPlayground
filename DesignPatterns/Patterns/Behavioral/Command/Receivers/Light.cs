

namespace DesignPatterns.Patterns.Behavioral.Command.Receivers
{
    /// <summary>
    /// The Receiver class performs the actual work when commands are executed.
    /// </summary>
    internal class Light
    {

        public void On() => Console.WriteLine("[Light] The light is ON.");
        public void Off() => Console.WriteLine("[Light] The light is OFF.");
    }
}
