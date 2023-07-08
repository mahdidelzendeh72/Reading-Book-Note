namespace DecoratorDesignPattern.extension_method
{
    /// <summary>
    /// Another alternative way to implement the Decorator pattern is by
    /// using extension methods in C#. Extension methods allow you to add 
    /// new methods to existing types without modifying their source code. 
    /// This approach can be useful when you want to add new functionalities
    /// to a class without creating a separate decorator class.
    /// </summary>
    // Extension methods for the component class
    public static class ComponentExtensions
    {
        public static void AdditionalOperationA(this Component component)
        {
            Console.WriteLine("Executing additional operation A");
        }

        public static void AdditionalOperationB(this Component component)
        {
            Console.WriteLine("Executing additional operation B");
        }
    }

}
