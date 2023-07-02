namespace ObserverDesignPattern.Interfacse
{
    // Subject interface
    public interface ISubject2
    {
        /// <summary>
        /// for attach or follow to observe
        /// </summary>
        /// <param name="observer"></param>
        void Attach(IObserver2 observer);
        /// <summary>
        /// for detach or unfollow the observe
        /// </summary>
        /// <param name="observer"></param>
        void Detach(IObserver2 observer);
        /// <summary>
        /// get notification for state updtae
        /// </summary>
        void Notify();
    }
}
