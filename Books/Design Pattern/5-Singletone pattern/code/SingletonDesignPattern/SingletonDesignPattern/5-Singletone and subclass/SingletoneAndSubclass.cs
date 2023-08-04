using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern._5_Singletone_and_subclass
{
    ///  To have a singleton class with a subclass, you can create the subclass as a nested class within the singleton class. Here's an example:
    ///  In this example, the Subclass is defined as a nested class within the Singleton class.  
    ///  It has its own methods and properties that can be accessed separately from the singleton instance.

    public sealed class Singleton
    {
        private Singleton() { }

        public static Singleton Instance { get; } = new Singleton();

        public class Subclass
        {
            public void DoSomething()
            {
                // Code for the subclass
            }
        }
    }
}
