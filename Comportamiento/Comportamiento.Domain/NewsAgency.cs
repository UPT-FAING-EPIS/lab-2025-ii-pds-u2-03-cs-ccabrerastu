using System;
using System.Collections.Generic;

namespace Comportamiento.Domain
{
    public class NewsAgency : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        public void PublishNews(string news)
        {
            Console.WriteLine($"[NewsAgency] Nueva noticia publicada: {news}");
            Notify(news);
        }
    }
}
