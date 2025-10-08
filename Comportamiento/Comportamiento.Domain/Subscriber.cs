using System;

namespace Comportamiento.Domain
{
    public class Subscriber : IObserver
    {
        public string Name { get; }
        public string LastNews { get; private set; } = "";

        public Subscriber(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            LastNews = message;
            Console.WriteLine($"[{Name}] recibió noticia: {message}");
        }
    }
}
