namespace ObserverDesignPattern.Event_base
{
    // Subject class
    public class SubjectEventBase
    {
        // Event declaration for notify change event in state
        public event Action<double> StateChanged;
        /// <summary>
        /// state that its change is deteckted
        /// </summary>
        private double state;
        public double State
        {
            get { return state; }
            set
            {
                state = value;
                // Trigger the event when the stock price changes
                StateChanged?.Invoke(state);
            }
        }
    }

}
