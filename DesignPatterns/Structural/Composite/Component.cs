namespace DesignPatterns.Structural.Composite
{
    public abstract class Component
    {
        public Component() { }

        public abstract string Operation();

        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }

    public class Leaf : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }
        public override bool IsComposite()
        {
            return false;
        }
    }

    public class Composite: Component
    {
        protected List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Component component in _children)
            {
                result += component.Operation();
                if (i != this._children.Count - 1)
                    result += "+";

                i++;
            }

            return result + ")";
        }
    }

    public class CompositeClient
    {
        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation()}\n");
        }

        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"RESULT: {component1.Operation()}\n");
        }
    }

}
