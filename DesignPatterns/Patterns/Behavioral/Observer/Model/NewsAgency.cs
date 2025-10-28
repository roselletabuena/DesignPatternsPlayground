using DesignPatterns.Patterns.Behavioral.Observer.Interfaces;

namespace DesignPatterns.Patterns.Behavioral.Observer.Model
{
    /// <summary>
    /// Concrete Subject — manages subscribers and notifies them of news updates.
    /// </summary>
    internal class NewsAgency : INewsPublisher
    {
        private readonly List<INewsSubscriber> _subscribers = new();

        public void Attach(INewsSubscriber subscriber)
        {
           _subscribers.Add(subscriber);
           Console.WriteLine($"[NewsAgency] Subscriber added: {subscriber.GetType().Name}");
        }

        public void Detach(INewsSubscriber subscriber)
        {
           _subscribers.Remove(subscriber);
           Console.WriteLine($"[NewsAgency] Subscriber removed: {subscriber.GetType().Name}");
        }

        public void Notify(string news)
        {
            Console.WriteLine($"\n[NewsAgency] Breaking News: {news}");
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(news);
            }
        }
    }
}
