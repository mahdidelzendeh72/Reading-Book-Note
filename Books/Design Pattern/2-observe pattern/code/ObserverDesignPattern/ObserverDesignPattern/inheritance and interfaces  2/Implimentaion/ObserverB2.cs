using ObserverDesignPattern.Interfacse;

namespace ObserverDesignPattern.Implimentaion
{
    /// <summary>
    /// observer are follow subject and should know it
    /// </summary>
    public class ObserverB2 : IObserver2
    {
        public void Update(int state)
        {
            Console.WriteLine("Observer B: Subject's state has changed to " + state);
        }
    }

}
