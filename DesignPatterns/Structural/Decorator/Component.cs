namespace DesignPatterns.Structural.Decorator
{
    public abstract class Component
    {
        public abstract string Operation();
    }

    public class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }

    public abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override string Operation()
        {
            if (_component != null)
                return _component.Operation();
            else
                return String.Empty;
        }

        public class ConcreteDecoratorA : Decorator
        {
            public ConcreteDecoratorA(Component comp)
                : base(comp) { }

            public override string Operation()
            {
                return $"ConcreteDecorator({base.Operation()})";
            }
        }

        public class ConcreteDecoratorB: Decorator
        {
            public ConcreteDecoratorB(Component comp)
                :base(comp)
            {

            }

            public override string Operation()
            {
                return $"ConcreteDecorationB({base.Operation()})";
            }
        }

        public class DecoratorClient
        {
            public void ClientCode(Component component)
            {
                Console.WriteLine("Result: " + component.Operation());
            }
        }
    }
}
