using Factory_design_pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_design_pattern.Reflection
{
    /// <summary>
    /// This approach can be useful when you have a large number of product
    /// types and want to avoid explicitly adding switch cases or if/else statements
    /// for each type in the factory method. However, it comes with a slight performance 
    /// overhead due to the use of reflection.
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
        public static IProduct CreateProduct(string type)
        {
            var productType = Type.GetType(type);
            if (productType == null || !typeof(IProduct).IsAssignableFrom(productType))
            {
                throw new ArgumentException("Invalid product type");
            }

            return (IProduct)Activator.CreateInstance(productType);
        }
    }

}
