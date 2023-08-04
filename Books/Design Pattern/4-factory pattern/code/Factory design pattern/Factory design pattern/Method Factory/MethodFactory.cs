using Factory_design_pattern.Model;

namespace Factory_design_pattern.Method_Factory
{
    ///Factory Method: In this pattern, a factory interface
    ///or abstract class is defined, and each subclass is
    ///responsible for creating a specific type of object. 
    ///This allows for more flexibility and extensibility 
    ///compared to the Simple Factory pattern.
    public abstract class Creator
    {
        public abstract IProduct CreateProduct();
    }

    public class ConcreteCreatorA : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ProductB();
        }
    }


}
