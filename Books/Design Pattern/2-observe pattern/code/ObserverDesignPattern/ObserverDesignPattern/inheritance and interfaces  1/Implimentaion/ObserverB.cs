using ObserverDesignPattern.Interfacse;

namespace ObserverDesignPattern.Implimentaion
{
    /// <summary>
    /// observer are follow subject and should know it
    /// </summary>
    public class ObserverB : IObserver
    {
        private Subject subject;

        public ObserverB(Subject subject)
        {
            this.subject = subject;
            subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine("Observer B: Subject's state has changed to " + subject.State);
        }
    }

}
