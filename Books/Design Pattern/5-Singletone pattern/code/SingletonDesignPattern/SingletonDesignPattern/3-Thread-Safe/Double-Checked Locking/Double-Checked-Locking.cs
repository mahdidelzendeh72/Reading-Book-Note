namespace SingletonDesignPattern._3_Thread_Safe.Double_Checked_Locking
{
    /// <summary>
    /// In this approach, the instance of the Singleton class is created lazily using double-checked locking.
    /// The volatile keyword ensures that the instance is correctly handled by multiple threads,
    /// and the lock statement provides thread safety when creating the instance
    /// </summary>
    public class Singleton_Double_Checked_Locking
    {
        private static volatile Singleton_Double_Checked_Locking instance;
        private static readonly object syncLock = new object();

        private Singleton_Double_Checked_Locking() { }

        public static Singleton_Double_Checked_Locking Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncLock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton_Double_Checked_Locking();
                        }
                    }
                }

                return instance;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton: Doing something...");
        }
    }
}
