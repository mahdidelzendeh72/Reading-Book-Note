using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reactive.Subjects;

namespace ObserverDesignPattern.Reactive_Extensions__Rx__library
{
    // Subject class
    public class StockMarket : IObservable<double>
    {
        private double stockPrice;
        private Subject<double> subject = new Subject<double>();

        public double StockPrice
        {
            get { return stockPrice; }
            set
            {
                stockPrice = value;
                subject.OnNext(stockPrice);
            }
        }

        public IDisposable Subscribe(IObserver<double> observer)
        {
            return subject.Subscribe(observer);
        }
    }

    // Observer classes
    public class InvestorA : IObserver<double>
    {
        public void OnCompleted()
        {
            // Not used in this example
        }

        public void OnError(Exception error)
        {
            // Not used in this example
        }

        public void OnNext(double stockPrice)
        {
            Console.WriteLine("Investor A: Stock price has changed to $" + stockPrice);
        }
    }

    public class InvestorB : IObserver<double>
    {
        public void OnCompleted()
        {
            // Not used in this example
        }

        public void OnError(Exception error)
        {
            // Not used in this example
        }

        public void OnNext(double stockPrice)
        {
            Console.WriteLine("Investor B: Stock price has changed to $" + stockPrice);
        }
    }
}
