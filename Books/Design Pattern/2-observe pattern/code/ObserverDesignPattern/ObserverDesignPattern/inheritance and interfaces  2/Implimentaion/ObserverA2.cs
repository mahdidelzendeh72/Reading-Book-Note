using ObserverDesignPattern.Interfacse;

namespace ObserverDesignPattern.Implimentaion
{
    // Concrete observer classes
    public class ObserverA2 : IObserver2
    {
        public void Update(int state)
        {
            Console.WriteLine("Observer A: Subject's state has changed to " + state);
        }
    }

}
