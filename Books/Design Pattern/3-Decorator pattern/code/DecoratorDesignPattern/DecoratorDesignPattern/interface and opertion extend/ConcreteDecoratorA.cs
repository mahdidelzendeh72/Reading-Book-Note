
// The base component interface

// The concrete component class

// The base decorator class

// Concrete decorator class
public class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(IComponent component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("Executing additional operation in ConcreteDecoratorA");
    }
}
