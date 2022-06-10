namespace DesignPatterns.FactoryMethod
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
        public string SomeOperation()
        {
            var product = FactoryMethod();
            var result = "Creator: The same creator's code has just worked with " + product.Operation();

            return result;
        }
    }

    public class ConcreteCreatorOne : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductOne();
        }
    }

    public class ConcreteCreatorTwo : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductTwo();
        }
    }

}
