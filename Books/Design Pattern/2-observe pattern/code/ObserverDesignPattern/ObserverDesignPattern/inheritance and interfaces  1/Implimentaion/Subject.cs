using ObserverDesignPattern.Interfacse;

namespace ObserverDesignPattern.Implimentaion
{
    /// <summary>
    /// Concrete subject class
    /// subject dont know observers and dont know what happend when their get notify
    /// </summary>
    public class Subject : ISubject
    {
        /// <summary>
        /// list of observer how arrr attach to subject
        /// </summary>
        private List<IObserver> observers = new List<IObserver>();
        /// <summary>
        /// the state where change and should notify to observers
        /// </summary>
        private int state;

        public int State
        {
            get { return state; }
            set
            {
                state = value;
                Notify();
            }
        }
        /// <summary>
        /// attach new observer
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }
        /// <summary>
        /// detach observer
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }
        /// <summary>
        /// notify observers
        /// </summary>
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }

}
