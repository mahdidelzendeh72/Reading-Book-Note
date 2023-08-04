using Factory_design_pattern.Attribute_Factory;

namespace Factory_design_pattern.Model
{
    [ProductType("A")]
    public class ProductA : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("Product A");
        }
    }

}
