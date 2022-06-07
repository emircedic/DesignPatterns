using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.FactoryMethod;

#region Factory Method

//Console.WriteLine("App: Launched with Factory Method");

//var concreteCreatorOne = new ConcreteCreatorOne();
//var concreteCreatorTwo = new ConcreteCreatorTwo();

//ClientFactoryMethod.ClientCode(concreteCreatorOne);
//ClientFactoryMethod.ClientCode(concreteCreatorTwo);

#endregion

#region Abstract Factory

//Console.WriteLine("App: Launched with Abstract Factory");

//var factoryOne = new ConcreteFactoryOne();
//var factoryTwo = new ConcreteFactoryTwo();

//ClientAbstractFactory.ClientMethod(factoryOne);
//ClientAbstractFactory.ClientMethod(factoryTwo);

#endregion

#region Builder

Console.WriteLine("App: Launched with Builder  ");

var director = new Director();
var builder = new ConcreteBuilder();

director.Builder = builder;
director.BuildFullFeaturedProduct();
var resultFullProduct = builder.GetProduct();

director.BuildMinimalViableProduct();
var resultMinimalProduct = builder.GetProduct();

Console.WriteLine(resultFullProduct.ListParts());
Console.WriteLine(resultMinimalProduct.ListParts());

builder.BuildPartA();
builder.BuildPartB();

Console.WriteLine(builder.GetProduct().ListParts());

var chainedBuilder = new ConcreteChainedBuilder();

var product = chainedBuilder.BuildPartA().BuildPartC().BuildPartC().GetProduct();
Console.WriteLine(product.ListParts());

#endregion