using Factory_design_pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory_design_pattern.Attribute_Factory
{
    ///This approach provides a flexible and extensible way to configure the
    ///product types and their mappings without modifying the factory class itself.
    ///It allows for easy addition or modification of product types by simply marking
    ///the classes with the appropriate attribute.
    /// <summary>
    /// Create an attribute to mark the product classes with their corresponding types.
    /// Create a factory class that scans the assembly for classes marked with the ProductType
    /// attribute and builds a mapping between product types and their corresponding 
    /// implementation classes
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ProductTypeAttribute : Attribute
    {
        public string Type { get; }

        public ProductTypeAttribute(string type)
        {
            Type = type;
        }
    }
    public class ProductFactoryAttribute
    {
        private readonly Dictionary<string, Type> productTypeMap;

        public ProductFactoryAttribute()
        {
            productTypeMap = new Dictionary<string, Type>();
            BuildProductTypeMap();
        }

        private void BuildProductTypeMap()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var productTypes = assembly.GetTypes()
                .Where(type => typeof(IProduct).IsAssignableFrom(type))
                .Where(type => type.GetCustomAttribute<ProductTypeAttribute>() != null);

            foreach (var productType in productTypes)
            {
                var attribute = productType.GetCustomAttribute<ProductTypeAttribute>();
                var type = attribute.Type;
                productTypeMap[type] = productType;
            }
        }

        public IProduct CreateProduct(string type)
        {
            if (productTypeMap.TryGetValue(type, out var productType))
            {
                return (IProduct)Activator.CreateInstance(productType);
            }

            throw new ArgumentException("Invalid product type");
        }
    }

}
