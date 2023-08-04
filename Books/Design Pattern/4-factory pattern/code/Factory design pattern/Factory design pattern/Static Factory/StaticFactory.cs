using Factory_design_pattern.Model;

namespace Factory_design_pattern.Static_Factory
{
    ///Static Factory Method: In this variation, the factory
    ///method is implemented as a static method within a class.
    ///This eliminates the need to create an instance of the factory 
    ///class to create objects.
    public class ProductFactory
    {
        public static IProduct CreateProduct(string type)
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
