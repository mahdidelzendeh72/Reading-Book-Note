using Factory_design_pattern.Model;

namespace Factory_design_pattern.DictionaryOfTypeFactory
{
    /// <summary>
    /// This approach allows for more flexibility in adding or modifying product types
    /// without modifying the factory class itself. It also enables the use of different
    /// creation strategies for different product types.
    /// </summary>


    public class ProductA : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("Product A");
        }
    }

    public class ProductB : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("Product B");
        }
    }

    public class ProductFactory
    {
        private readonly Dictionary<string, Func<IProduct>> productCreationMap;

        public ProductFactory()
        {
            productCreationMap = new Dictionary<string, Func<IProduct>>();
            RegisterProduct("A", () => new ProductA());
           
        }

        public void RegisterProduct(string type, Func<IProduct> creationFunc)
        {
            productCreationMap[type] = creationFunc;
        }

        public IProduct CreateProduct(string type)
        {
            if (productCreationMap.TryGetValue(type, out var creationFunc))
            {
                return creationFunc.Invoke();
            }

            throw new ArgumentException("Invalid product type");
        }
    }

}
