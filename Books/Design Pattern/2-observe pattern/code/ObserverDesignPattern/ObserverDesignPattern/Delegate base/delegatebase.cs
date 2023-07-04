using System.Reactive.Linq;

﻿namespace ObserverDesignPattern.Delegate_base
{
    // Delegate for the update method
    public delegate void StateChangedHandler(double stockPrice);

    // Subject class
    public class StockMarketAsSubject
    {
        private double stockPrice;

        // Event for stock price change
        public event StateChangedHandler StateChanged;

        public double StockPrice
        {
            get { return stockPrice; }
            set
            {
                stockPrice = value;
                OnStateChanged(stockPrice);
            }
        }

        protected virtual void OnStateChanged(double stockPrice)
        {
            StateChanged?.Invoke(stockPrice);

        }
    }

    // Observer classes
    public class InvestorAsObserverA
    {
        public void Update(double stockPrice)
        {
            Console.WriteLine("Investor A: Stock price has changed to $" + stockPrice);
        }
    }

    public class InvestorAsObserverB
    {
        public void Update(double stockPrice)
        {
            Console.WriteLine("Investor B: Stock price has changed to $" + stockPrice);
        }
    }

   

}
