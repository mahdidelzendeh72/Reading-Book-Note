
// The base component interface

// The concrete component class

// The base decorator class

// Concrete decorator class

// Another concrete decorator class
public class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(IComponent component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("Executing additional operation in ConcreteDecoratorB");
    }
}
