using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern._1_PrivateConstructor
{
    /// <summary>
    /// In this example, the Singleton class has a private constructor to prevent direct instantiation. 
    /// The GetInstance() method is used to get the instance of the Singleton class.
    /// It checks if an instance already exists, and if not, it creates a new instance.
    /// The DoSomething() method represents some action that can be performed by the singleton object.
    /// </summary>
    public class Singleton_PrivateConstructor
    {
        private static Singleton_PrivateConstructor instance;

        // Private constructor to prevent instantiation from outside the class
        private Singleton_PrivateConstructor() { }

        // Public static method to get the instance of the Singleton class
        public static Singleton_PrivateConstructor GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton_PrivateConstructor();
            }

            return instance;
        }

        // Public method to perform some action
        public void DoSomething()
        {
            Console.WriteLine("Singleton: Doing something...");
        }
    }
}
