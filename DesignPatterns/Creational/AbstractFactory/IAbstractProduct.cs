namespace DesignPatterns.AbstractFactory
{
    public interface IAbstractProductA
    {
        string UserfulFunctionA();
    }
    public interface IAbstractProductB
    {
        string UserfulFunctionB();
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }

    public class ConcreteProductAOne : IAbstractProductA
    {
        public string UserfulFunctionA()
        {
            return nameof(ConcreteProductAOne);
        }
    }

    public class ConcreteProductBOne : IAbstractProductB
    {
        public string UserfulFunctionB()
        {
            return nameof(ConcreteProductBOne);
        }
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UserfulFunctionA();
            return $"The result of BOne collaboration with the {result}";
        }

    }

    public class ConcreteProductATwo : IAbstractProductA
    {
        public string UserfulFunctionA()
        {
            return nameof(ConcreteProductATwo);
        }
    }

    public class ConcreteProductBTwo : IAbstractProductB
    {
        public string UserfulFunctionB()
        {
            return nameof(ConcreteProductBTwo);
        }
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UserfulFunctionA();
            return $"The result of BTwo collaboration with the {result}"; ;
        }
    }
}
