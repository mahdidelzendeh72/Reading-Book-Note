namespace Factory_design_pattern.Abstract_Factory
{
    /// Abstract Factory: This pattern provides an interface
    /// for creating families of related or dependent objects
    /// .It is useful when you need to create multiple related
    /// objects that belong to the same family.
    /// 
    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }

    public partial interface IProductA
    {
        void DoSomething();
    }

    public partial interface IProductB
    {
        void DoSomething();
    }

    public class ConcreteFactory1 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactory2 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    public class ProductA1 : IProductA
    {
        public void DoSomething()
        {
            Console.WriteLine("Product A1");
        }
    }

    public class ProductA2 : IProductA
    {
        public void DoSomething()
        {
            Console.WriteLine("Product A2");
        }
    }

    public class ProductB1 : IProductB
    {
        public void DoSomething()
        {
            Console.WriteLine("Product B1");
        }
    }

    public class ProductB2 : IProductB
    {
        public void DoSomething()
        {
            Console.WriteLine("Product B2");
        }
    }

}
