using ObserverDesignPattern.Delegate_base;
using ObserverDesignPattern.Event_base;
using ObserverDesignPattern.Implimentaion;
using ObserverDesignPattern.Reactive_Extensions__Rx__library;

public class Program
{
    public static void Main(string[] args)
    {
        //------------------  implement interfaces 1 -----------
        Subject subject = new Subject();
        ObserverA observerA = new ObserverA(subject);
        ObserverB observerB = new ObserverB(subject);

        subject.State = 5; // Output: Observer A: Subject's state has changed to 5
                           //         Observer B: Subject's state has changed to 5

        subject.State = 10; // Output: Observer A: Subject's state has changed to 10
                            //         Observer B: Subject's state has changed to 10

        subject.Detach(observerA);
        subject.State = 15; // Output: Observer B: Subject's state has changed to 15


        //-------------------  event base -----------------------
        SubjectEventBase stockMarket1 = new SubjectEventBase();
        ObserverEventA investorA1 = new ObserverEventA();
        ObserverEventB investorB1 = new ObserverEventB();

        investorA1.Subscribe(stockMarket1);
        investorB1.Subscribe(stockMarket1);

        stockMarket1.State = 100; // Output: Investor A: Stock price has changed to $100
                                  //         Investor B: Stock price has changed to $100

        stockMarket1.State = 150; // Output: Investor A: Stock price has changed to $150
                                  //         Investor B: Stock price has changed to $150

        investorA1.Unsubscribe(stockMarket1);
        stockMarket1.State = 200; // Output: Investor B: Stock price has changed to $200

        //------------------  implement interfaces  2 -----------
        Subject2 subject2 = new Subject2();
        ObserverA2 observerA2 = new ObserverA2();
        ObserverB2 observerB2 = new ObserverB2();

        subject2.State = 5; // Output: Observer A: Subject's state has changed to 5
                            //         Observer B: Subject's state has changed to 5

        subject2.State = 10; // Output: Observer A: Subject's state has changed to 10
                             //         Observer B: Subject's state has changed to 10

        subject2.Detach(observerA2);
        subject2.State = 15; // Output: Observer B: Subject's state has changed to 15

        //-------------------- delegate --------------------------------

        StockMarketAsSubject stockMarket = new StockMarketAsSubject();
        InvestorAsObserverA investorA = new InvestorAsObserverA();
        InvestorAsObserverB investorB = new InvestorAsObserverB();

        // Subscribe observers to the event
        stockMarket.StateChanged += investorA.Update;
        stockMarket.StateChanged += investorB.Update;

        stockMarket.StockPrice = 100; // Output: Investor A: Stock price has changed to $100
                                      //         Investor B: Stock price has changed to $100

        stockMarket.StockPrice = 150; // Output: Investor A: Stock price has changed to $150
                                      //         Investor B: Stock price has changed to $150

        // Unsubscribe an observer from the event
        stockMarket.StateChanged -= investorA.Update;

        stockMarket.StockPrice = 200; // Output: Investor B: Stock price has changed to $200

        //--------------------  Reactive Extensions (Rx) library -----------------
        StockMarket stockMarket3 = new StockMarket();
        InvestorA investorA3 = new InvestorA();
        InvestorB investorB3 = new InvestorB();

        // Subscribe observers to the subject
        stockMarket3.Subscribe(investorA3);
        stockMarket3.Subscribe(investorB3);

        stockMarket3.StockPrice = 100; // Output: Investor A: Stock price has changed to $100
                                      //         Investor B: Stock price has changed to $100

        stockMarket3.StockPrice = 150; // Output: Investor A: Stock price has changed to $150
                                      //         Investor B: Stock price has changed to $150

        // Unsubscribe an observer from the subject
        stockMarket3.Subscribe(investorA3).Dispose();

        stockMarket3.StockPrice = 200; // Output: Investor B: Stock price has changed to $200

    }
}