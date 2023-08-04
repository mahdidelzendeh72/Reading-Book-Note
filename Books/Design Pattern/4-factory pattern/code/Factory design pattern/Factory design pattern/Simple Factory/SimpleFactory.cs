using Factory_design_pattern.Model;

namespace Factory_design_pattern.Simple_Factory
{
    /// <summary>
    /// Simple Factory: This is not an official design pattern,
    /// but it is often used as a starting point for understanding
    /// the concept of factories. In this pattern, a single factory
    /// class is responsible for creating objects based on a given input.
    /// </summary>
    public class SimpleFactory
    {
        public IProduct CreateProduct(string type)
        {
            switch (type)
            {
                case "A":
                    return new ProductA();
                case "B":
                    return new ProductB();
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }
    }

   

    

}
