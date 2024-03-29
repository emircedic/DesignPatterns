﻿using DesignPatterns.AbstractFactory;
using DesignPatterns.Behavioral.ChainOfResponsability;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor;
using DesignPatterns.Builder;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Prototype;
using DesignPatterns.Singleton.SingletonNonThreadSafe;
using DesignPatterns.Singleton.ThreadSafe;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Proxy;
using static DesignPatterns.Structural.Decorator.Decorator;
using static DesignPatterns.Structural.Facade.Facade;

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

#region Singleton

//// Non Thread Safe
//SingletonNonThreadSafe s1 = SingletonNonThreadSafe.GetInstance();
//SingletonNonThreadSafe s2 = SingletonNonThreadSafe.GetInstance();

//if (s1 == s2)
//    Console.WriteLine("They are the same!");
//else
//    Console.WriteLine("They are not the same!");

//// Thread Safe

//Thread process1 = new Thread(() =>
//{
//    TestSingleton("FOO");
//});

//Thread process2 = new Thread(() =>
//{
//    TestSingleton("BAR");
//});

//process1.Start();
//process2.Start();

//process1.Join();
//process2.Join();


//static void TestSingleton(string value)
//{
//    SingletonThreadSafe singleton = SingletonThreadSafe.GetInstance(value);
//    Console.WriteLine(singleton.Value);
//}

#endregion

#region Adaptee

//Adaptee adaptee = new Adaptee();
//ITarget target = new Adapter(adaptee);

//Console.WriteLine("Adaptee interface is incompatible with the client.");
//Console.WriteLine("But with the adapter client can call its method.");

//Console.WriteLine(target.GetRequest());

#endregion

#region Bridge

//Client client = new Client();
//Abstraction abstraction = new Abstraction(new ConcreteImplementationA());
//client.ClientCode(abstraction);

//Console.WriteLine();

//abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
//client.ClientCode(abstraction);

#endregion

#region Composite 

//CompositeClient client = new CompositeClient();

//Leaf leaf = new Leaf();
//Console.WriteLine("Client: I get a simple component:");
//client.ClientCode(leaf);

//Composite tree = new Composite();
//Composite branch1 = new Composite();
//branch1.Add(new Leaf());
//branch1.Add(new Leaf());
//Composite branch2 = new Composite();
//branch2.Add(new Leaf());
//tree.Add(branch1);
//tree.Add(branch2);

//Console.WriteLine("Client: Now Ive got a composite tree:");
//client.ClientCode(tree);

//Console.WriteLine("Client: I dont need ot check the components classes even when managing the tree:\n");
//client.ClientCode2(tree, leaf);

#endregion

#region Decorator

//DecoratorClient client = new DecoratorClient();

//var simple = new ConcreteComponent();
//Console.WriteLine("Client: I get a simple component");
//client.ClientCode(simple);
//Console.WriteLine();

//ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
//ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
//Console.WriteLine("Client: Now Ive got a decorated compoennt: ");
//client.ClientCode(decorator2);

#endregion

#region Facade

//Subsystem1 subsystem1 = new Subsystem1();
//Subsystem2 subsystem2 = new Subsystem2();

//Facade facade = new Facade(subsystem1, subsystem2);

//FacadeClient.ClientCode(facade);

#endregion

#region Flyweight

//var factory = new FlywieghtFactory(new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
//                                   new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
//                                   new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
//                                   new Car { Company = "BMW", Model = "M5", Color = "red" },
//                                   new Car { Company = "BMW", Model = "X6", Color = "white" });

//factory.ListFlyweights();

//FlyweightExecute.AddCarToPoliceDatabase(factory, new Car
//{
//    Number = "CL234IR",
//    Owner = "James Doe",
//    Company = "BMW",
//    Model = "M5",
//    Color = "red"
//});

//FlyweightExecute.AddCarToPoliceDatabase(factory, new Car
//{
//    Number = "CL234IR",
//    Owner = "James Doe",
//    Company = "BMW",
//    Model = "X1",
//    Color = "red"
//});

//factory.ListFlyweights();

#endregion

#region Proxy

//ProxyClient proxyClient = new ProxyClient();

//Console.WriteLine("Client: Executing the client code with a real subject:");
//RealSubject realSubject = new RealSubject();
//proxyClient.ClientCode(realSubject);

//Console.WriteLine();

//Console.WriteLine("Client: Executing the same client code with a proxy:");
//Proxy proxy = new Proxy(realSubject);
//proxyClient.ClientCode(proxy);

#endregion

#region Chain of responsability 

//var monkeyHandler = new MonkeyHandler();
//var squirrelHandler = new SquirrelHandler();
//var dogHandler = new DogHandler();

//monkeyHandler.SetNext(squirrelHandler).SetNext(dogHandler);

//Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
//CoRClient.ClientCode(monkeyHandler);
//Console.WriteLine();

//Console.WriteLine("Subchain: Squirrel > Dog\n");
//CoRClient.ClientCode(squirrelHandler);

#endregion

#region Command

//Invoker invoker = new Invoker();
//invoker.SetOnStart(new SimpleCommand("Say hi!"));
//Receiver receiver = new Receiver();
//invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

//invoker.DoSomethingImportant();

#endregion

#region Iterator

//var collection = new WordsCollection();
//collection.AddItem("First");
//collection.AddItem("Second");
//collection.AddItem("Third");

//Console.WriteLine($"Straight traversal: ");

//foreach (var element in collection)
//    Console.WriteLine(element);

//Console.WriteLine($"\nReverse traversal:");
//collection.ReverseDirection();

//foreach (var element in collection)
//    Console.WriteLine(element);

#endregion

#region Mediator

//Component1 component1 = new Component1();
//Component2 component2 = new Component2();

//new ConcreteMediator(component1, component2);

//Console.WriteLine("Client triggers operation A");
//component1.DoA();

//Console.WriteLine();

//Console.WriteLine("Client triggers operation D");
//component2.DoD();

#endregion

#region Memento

//Originator originator = new Originator("Super-duper-super-puper-super");
//Caretaker caretaker = new Caretaker(originator);

//caretaker.Backup();
//originator.DoSomething();

//caretaker.Backup();
//originator.DoSomething();

//caretaker.Backup();
//originator.DoSomething();

//Console.WriteLine();
//caretaker.ShowHistory();

//Console.WriteLine("\nClient: Now, lets rollback!\n");
//caretaker.Undo();

//Console.WriteLine("\n\nClient: Once more!\n");
//caretaker.Undo();

//Console.WriteLine();

#endregion

#region Observer

//var subject = new Subject();
//var observerA = new ConcreteObserverA();
//subject.Attach(observerA);

//var observerB = new ConcreteObserverB();
//subject.Attach(observerB);

//subject.SomeBusinessLogic();
//subject.SomeBusinessLogic();

//subject.Detach(observerB);

//subject.SomeBusinessLogic();

#endregion

#region State

//var context = new StateContext(new ConcreteStateA());
//context.Request1();
//context.Request2();

#endregion

#region Strategy

//var context = new StrategyContext();

//Console.WriteLine("Client: Strategy is set to normal sorting.");
//context.SetStrategy(new ConcreteStrategyA());
//context.DoSomeBusinessLogic();

//Console.WriteLine();

//Console.WriteLine("Client: Strategy is set to reverse sorting.");
//context.SetStrategy(new ConcreteStrategyB());
//context.DoSomeBusinessLogic();

#endregion

#region Template method

//Console.WriteLine("Same client code can work with different subclasses:");
//TemplateMethodClient.ClientClode(new ConcreteClass1());

//Console.WriteLine("\n");

//Console.WriteLine("Smae client code can work with different subclasses:");
//TemplateMethodClient.ClientClode(new ConcreteClass2());

#endregion

#region Visitor

List<IComponent> components = new List<IComponent>
{
    new ConcreteComponentA(),
    new ConcreteComponentB()
};

Console.WriteLine("The client code works with all visitors via the base Visitor interface");

var visitor1 = new ConcreteVisitor1();
VisitorClient.ClientCode(components, visitor1);

Console.WriteLine();

Console.WriteLine("It allows the same client code to work with different types of visitors:");
var visitor2 = new ConcreteVisitor2();
VisitorClient.ClientCode(components, visitor2);

#endregion
