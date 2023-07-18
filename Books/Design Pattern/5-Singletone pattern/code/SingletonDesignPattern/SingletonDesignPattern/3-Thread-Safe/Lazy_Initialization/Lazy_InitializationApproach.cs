namespace SingletonDesignPattern._3_Thread_Safe.Lazy_Initialization
{
    /// <summary>
    /// In this approach, the instance of the Singleton class is created lazily using the Lazy<T> class, 
    /// which ensures thread safety. The instance is created when the Value property of the lazyInstance field is accessed for the first time
    /// </summary>
    public class Singleton_LazyInitialization
    {
        private static readonly Lazy<Singleton_LazyInitialization> lazyInstance = new (() => new Singleton_LazyInitialization());
        //private static readonly Lazy<Singleton_LazyInitialization> lazyInstance = new Lazy<Singleton_LazyInitialization>(() => new Singleton_LazyInitialization());

        private Singleton_LazyInitialization() { }

        public static Singleton_LazyInitialization Instance
        {
            get { return lazyInstance.Value; }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton: Doing something...");
        }
    }
}
