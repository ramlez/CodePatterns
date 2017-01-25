using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Classes
{
    class NewsSubscriber : IObserver
    {
        private string _dailyNews;

        public void Update(string news)
        {
            _dailyNews = news;
        }

        public void PrintNews()
        {
            Console.WriteLine(_dailyNews);
        }
    }
}
