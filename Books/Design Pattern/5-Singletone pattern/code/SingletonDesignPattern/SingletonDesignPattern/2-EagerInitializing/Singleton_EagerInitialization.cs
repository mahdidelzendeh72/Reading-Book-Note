namespace SingletonDesignPattern._2_EagerInitializing
{
    /// <summary>
    /// In this approach, the instance of the Singleton class is created eagerly as a static readonly field.
    /// This ensures that the instance is created when the class is loaded and eliminates the need for checking if the instance is null.
    /// </summary>
    public class Singleton_EagerInitialization
    {
        //Eager Initialization
        private static readonly Singleton_EagerInitialization instance = new Singleton_EagerInitialization();

        private Singleton_EagerInitialization() { }

        public static Singleton_EagerInitialization Instance
        {
            //eliminates the need for checking if the instance is null
            get { return instance; }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton: Doing something...");
        }
    }
}
