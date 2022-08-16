namespace DesignPatterns.Behavioral.Visitor
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }

    public class ConcreteComponentA : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }

        public string ExclusiveMethodOfConcreteComponentA()
        {
            return "A";
        }
    }

    public class ConcreteComponentB : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentB(this);
        }

        public string ExclusiveMethodOfConcreteComponentB()
        {
            return "B";
        }
    }

    public interface IVisitor
    {
        void VisitConcreteComponentA(ConcreteComponentA component);
        void VisitConcreteComponentB(ConcreteComponentB component);
    }

    public class ConcreteVisitor1 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA component)
        {
            Console.WriteLine(component.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor1.");
        }

        public void VisitConcreteComponentB(ConcreteComponentB component)
        {
            Console.WriteLine(component.ExclusiveMethodOfConcreteComponentB() + " + ConcreteVisitor1.");
        }
    }

    public class ConcreteVisitor2 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA component)
        {
            Console.WriteLine(component.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor2.");
        }

        public void VisitConcreteComponentB(ConcreteComponentB component)
        {
            Console.WriteLine(component.ExclusiveMethodOfConcreteComponentB() + " + ConcreteVisitor2.");
        }
    }

    public class VisitorClient
    {
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (IComponent component in components)
                component.Accept(visitor);
        }
    }

}
