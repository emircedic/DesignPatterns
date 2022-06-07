namespace DesignPatterns.FactoryMethod
{
    public interface IProduct
    {
        string Operation();
    }

    public class ConcreteProductOne : IProduct
    {
        public string Operation()
        {
            return nameof(ConcreteProductOne);
        }
    }

    public class ConcreteProductTwo : IProduct
    {
        public string Operation()
        {
            return nameof(ConcreteProductTwo);
        }
    }
}
