using Factory_design_pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_design_pattern.SingletoneFactory
{
    /// <summary>
    /// Singleton Factory: In this variation, the factory class itself is
    /// implemented as a singleton. This ensures that there is only one instance
    /// of the factory class throughout the application, and it can be accessed globally
    /// to create objects.
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
        private static ProductFactory instance;

        private ProductFactory() { }

        public static ProductFactory Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductFactory();
                return instance;
            }
        }

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
