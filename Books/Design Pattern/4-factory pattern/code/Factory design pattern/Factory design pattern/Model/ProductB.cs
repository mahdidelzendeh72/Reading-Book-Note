using Factory_design_pattern.Attribute_Factory;

namespace Factory_design_pattern.Model
{

    [ProductType("B")]
    public class ProductB : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("Product B");
        }
    }

}
