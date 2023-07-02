using ObserverDesignPattern.Interfacse;

namespace ObserverDesignPattern.Implimentaion
{
    // Concrete observer classes
    public class ObserverA : IObserver
    {
        private Subject subject;

        public ObserverA(Subject subject)
        {
            this.subject = subject;
            subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine("Observer A: Subject's state has changed to " + subject.State);
        }
    }

}
