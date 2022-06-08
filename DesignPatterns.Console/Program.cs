﻿using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Prototype;

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

//Console.WriteLine("App: Launched with Builder  ");

//var director = new Director();
//var builder = new ConcreteBuilder();

//director.Builder = builder;
//director.BuildFullFeaturedProduct();
//var resultFullProduct = builder.GetProduct();

//director.BuildMinimalViableProduct();
//var resultMinimalProduct = builder.GetProduct();

//Console.WriteLine(resultFullProduct.ListParts());
//Console.WriteLine(resultMinimalProduct.ListParts());

//builder.BuildPartA();
//builder.BuildPartB();

//Console.WriteLine(builder.GetProduct().ListParts());

//var chainedBuilder = new ConcreteChainedBuilder();

//var product = chainedBuilder.BuildPartA().BuildPartC().BuildPartC().GetProduct();
//Console.WriteLine(product.ListParts());

#endregion

#region Prototype

//Person p1 = new Person();
//p1.Age = 42;
//p1.BirthDate = Convert.ToDateTime("1977-01-01");
//p1.Name = "Jack Daniels";
//p1.IdInfo = new IdInfo(666);

//Person p2 = p1.ShallowCopy();
//Person p3 = p2.DeepCopy();

//DisplayValues(p1);
//DisplayValues(p2);
//DisplayValues(p3);

//p1.Age = 32;
//p1.BirthDate = Convert.ToDateTime("1900-01-01");
//p1.Name = "Frank";
//p1.IdInfo.IdNumber = 7878;

//Console.WriteLine("Changed values:");

//DisplayValues(p1);
//DisplayValues(p2);
//DisplayValues(p3);

//static void DisplayValues(Person p)
//{
//    Console.WriteLine(String.Format("Name: {0}, Age: {1}, BirthDate: {2}\n ID: {3}", p.Name, p.Age, p.BirthDate, p.IdInfo.IdNumber));
//}

#endregion