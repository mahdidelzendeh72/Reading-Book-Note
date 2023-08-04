using Autofac;
using Factory_design_pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Dependency Injection: In this approach, the factory
/// is not explicitly implemented as a separate class or method.
/// Instead, the object creation is delegated to a dependency
/// injection framework or container. The framework is responsible
/// for creating and injecting the appropriate object based on the requested type.
/// </summary>
namespace Factory_design_pattern.DI_Container
{


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

   // see>>>>>>>>> program.cs
}
