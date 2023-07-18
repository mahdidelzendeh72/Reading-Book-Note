using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern._4_Singleton_And_Reflection
{
    /// <summary>
    /// In C#, the problem with Singleton and reflection arises due to the accessibility of the private constructor of the Singleton class.
    /// The Singleton pattern typically involves a private constructor that restricts the instantiation of the class from outside.
    /// However, reflection allows access to private members of a class, including the constructor.
    ///Using reflection, it is possible to bypass the private constructor and create multiple instances of the Singleton class, 
    ///which violates the intent of having only one instance.
   /// To mitigate this issue, additional precautions can be taken in the Singleton implementation.
   /// One approach is to throw an exception in the private constructor if an instance already exists,
   /// preventing the creation of multiple instances even through reflection.
   /// Another way to address this problem is by using a flag in the Singleton class to track whether an instance has already been created.
   /// In the private constructor, the flag can be checked, and if an instance already exists, an exception can be thrown.
   /// Overall, the problem with Singleton and reflection in C# is that reflection allows access to private members,
   /// including the constructor, which can lead to the creation of multiple instances of the Singleton class.
    /// </summary>
    public sealed class Singleton_Reflaction
    {
        private static Singleton_Reflaction instance = null;
        private static readonly object lockObject = new object();
        private static bool instanceCreated = false;
        /// <summary>
        /// In this implementation, we added a bool flag instanceCreated to track whether an instance has already been created.
        /// In the private constructor, we check the value of this flag. If it's true, indicating that an instance already exists,
        /// we throw an exception.
        /// </summary>
        /// <exception cref="Exception"></exception>
        private Singleton_Reflaction()
        {
            // Check if an instance already exists
            if (instanceCreated)
            {
                throw new Exception("Singleton instance already exists.");
            }

            // Set the flag to indicate that an instance has been created
            instanceCreated = true;
        }

        public static Singleton_Reflaction Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton_Reflaction();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
