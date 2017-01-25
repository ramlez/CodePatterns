using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ObserverPattern.Interfaces
{
    public interface ISubject
    {
        void Register(IObserver observer);
        void UnRegister(IObserver observer);
        void NotifyObservers();
    }
}