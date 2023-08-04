// See https://aka.ms/new-console-template for more information
using Autofac;
using Factory_design_pattern.Attribute_Factory;
using Factory_design_pattern.DI_Container;
using Factory_design_pattern.DictionaryOfTypeFactory;
using Factory_design_pattern.Model;

Console.WriteLine("Hello, World!");
//--------------- DI Container -------------
// Configuration using Autofac
var builder = new ContainerBuilder();
builder.RegisterType<Factory_design_pattern.DI_Container.ProductA>().As<IProduct>().Named<IProduct>("A");
builder.RegisterType<Factory_design_pattern.DI_Container.ProductB>().As<IProduct>().Named<IProduct>("B");
var container = builder.Build();

// Usage
var productA = container.ResolveNamed<IProduct>("A");
var productB = container.ResolveNamed<IProduct>("B");

/// ---------  dictionary of type -------
/// 
var factory = new ProductFactory();
factory.RegisterProduct("B", () => new Factory_design_pattern.DictionaryOfTypeFactory.ProductB());

var ProductA = factory.CreateProduct("A");
var ProductB = factory.CreateProduct("B");

ProductA.DoSomething(); // Output: Product A
ProductB.DoSomething(); // Output: Product B
///---- attribute --------
///
var factory2 = new ProductFactoryAttribute();

var productA2 = factory.CreateProduct("A");
var productB2 = factory.CreateProduct("B");

productA2.DoSomething(); // Output: Product A
productB2.DoSomething();

