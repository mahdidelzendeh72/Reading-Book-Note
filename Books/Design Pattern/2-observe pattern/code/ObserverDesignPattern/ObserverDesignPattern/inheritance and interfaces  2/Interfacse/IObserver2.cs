namespace ObserverDesignPattern.Interfacse
{
    // Observer interface
    public interface IObserver2
    {
        /// <summary>
        /// for have a handler from subject for notify
        /// </summary>
        void Update(int state);
    }
}
