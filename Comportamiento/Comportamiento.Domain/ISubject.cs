using System.Collections.Generic;

namespace Comportamiento.Domain
{
    // Interfaz para el sujeto (Observable)
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message);
    }
}
