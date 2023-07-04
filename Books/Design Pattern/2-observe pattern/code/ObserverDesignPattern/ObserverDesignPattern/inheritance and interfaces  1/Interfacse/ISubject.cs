namespace ObserverDesignPattern.Interfacse
{
    // Subject interface
    public interface ISubject
    {
        /// <summary>
        /// for attach or follow to observe
        /// </summary>
        /// <param name="observer"></param>
        void Attach(IObserver observer);
        /// <summary>
        /// for detach or unfollow the observe
        /// </summary>
        /// <param name="observer"></param>
        void Detach(IObserver observer);
        /// <summary>
        /// get notification for state updtae
        /// </summary>
        void Notify();
    }
}
