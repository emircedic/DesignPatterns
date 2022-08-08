namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperations1();
            BaseOperation2();
            Hook1();
            RequiredOperations2();
            BaseOperation3();
            Hook2();
        }

        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass says:But I let subclasses override some operations");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");
        }

        protected abstract void RequiredOperations1();
        protected abstract void RequiredOperations2();

        protected virtual void Hook1() { }
        protected virtual void Hook2() { }
    }

    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation1");
        }

        protected override void RequiredOperations2()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation2");
        }
    }

    public class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation1");
        }

        protected override void RequiredOperations2()
        {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation2");
        }
    }

    public class TemplateMethodClient
    {
        public static void ClientClode(AbstractClass abstractClass)
        {
            abstractClass.TemplateMethod();
        }
    }

}
