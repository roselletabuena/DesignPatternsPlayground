
namespace DesignPatterns.Patterns.Behavioral.Command.Receivers
{
    /// <summary>
    /// Another Receiver — a fan that can start or stop.
    /// </summary>
    internal class Fan
    {
        public void Start() => Console.WriteLine("[Fan] The fan is spinning.");
        public void Stop() => Console.WriteLine("[Fan] The fan has stopped.");
    }
}
