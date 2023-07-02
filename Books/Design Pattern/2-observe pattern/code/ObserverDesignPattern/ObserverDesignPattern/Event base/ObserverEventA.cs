namespace ObserverDesignPattern.Event_base
{
    public class ObserverEventA 
    {
        public void Subscribe(SubjectEventBase subjectEventBase)
        {
            // Subscribe to the StateChanged event
            subjectEventBase.StateChanged += Update;
        }

        public void Unsubscribe(SubjectEventBase subjectEventBase)
        {
            // Unsubscribe from the StateChanged event
            subjectEventBase.StateChanged -= Update;
        }
        /// <summary>
        /// the update method with the  same signuture as event in subject
        /// </summary>
        /// <param name="state"></param>
        private void Update(double state)
        {
            Console.WriteLine("Investor A: Stock price has changed to $" + state);
        }
    }

}
