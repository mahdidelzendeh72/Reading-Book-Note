
// Usage example
using DecoratorDesignPattern.extension_method;
using DecoratorDesignPattern.middleware;
/// <summary>
/// The Decorator design pattern is a structural design pattern that allows you
/// to add new behaviors or functionalities to an object dynamically without changing
/// its original structure. It is useful when you want to extend the functionality of
/// an object at runtime without modifying its code.
///In the Decorator pattern, you have a base class or interface 
///that defines the common functionality, and then you have concrete
///classes that implement this base class or interface. The decorator
///classes also implement the same base class or interface and wrap 
///the original object, adding new functionalities.
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        ///---------------- interface --------------
        // Create a concrete component
        IComponent component = new ConcreteComponent();

        // Wrap the component with decorators
        component = new ConcreteDecoratorA(component);
        component = new ConcreteDecoratorB(component);

        // Call the operation
        component.Operation();

        ///--------------------- extension method --------------
        // Usage example


        // Create a component object
        Component component2 = new Component();

        // Call the operations
        component2.Operation();
        component2.AdditionalOperationA();
        component2.AdditionalOperationB();


        ///------------- middle ware ---------
        // Create an instance of the final middleware
        var finalMiddleware = new FinalMiddleware();

        // Create an instance of the logging middleware and pass the final middleware as the next middleware
        var loggingMiddleware = new LoggingMiddleware(finalMiddleware);

        // Create an instance of the authentication middleware and pass the logging middleware as the next middleware
        var authenticationMiddleware = new AuthenticationMiddleware(loggingMiddleware);

        // Call the Execute method on the authentication middleware to start the chain
        authenticationMiddleware.Execute("Data to be processed");


    }
}
