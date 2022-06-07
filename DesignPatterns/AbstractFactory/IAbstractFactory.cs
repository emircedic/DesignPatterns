namespace DesignPatterns.AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }

    public class ConcreteFactoryOne : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductAOne();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductBOne();
        }
    }

    public class ConcreteFactoryTwo : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductATwo();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductBTwo();
        }
    }
}
