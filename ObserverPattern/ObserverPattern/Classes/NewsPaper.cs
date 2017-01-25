using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes
{
    class NewsPaper : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _newsMessage = "No news yet";

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_newsMessage);
            }
        }

        public void UpdateNews(string breakingNews)
        {
            _newsMessage = breakingNews;
            NotifyObservers();
        }
    }
}
