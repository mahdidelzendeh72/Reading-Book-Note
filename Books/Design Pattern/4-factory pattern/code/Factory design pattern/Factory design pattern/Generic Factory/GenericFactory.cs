using Factory_design_pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_design_pattern.Generic_Factory
{

    /// <summary>
    /// The CreateProduct method creates a new instance of type T using 
    /// the parameterless constructor.
    /// </summary>
    /// 
    ///This approach provides a more concise and type-safe way
    ///to create objects using the Factory pattern. It eliminates 
    ///the need for explicit type checks or reflection, as the generic
    ///type parameter ensures that only valid product types can be used with the factory.
    public class ProductFactory<T> where T : IProduct, new()
    {
        public T CreateProduct()
        {
            return new T();
        }
    }

}
