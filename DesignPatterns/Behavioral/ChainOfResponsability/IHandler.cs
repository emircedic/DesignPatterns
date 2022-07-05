namespace DesignPatterns.Behavioral.ChainOfResponsability
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }

    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
                return _nextHandler.Handle(request);
            else
                return null;
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
    }

    public class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Banana")
                return $"Monkey: Ill eat the {request.ToString()}.\n";
            else return base.Handle(request);
        }
    }

    public class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Nut")
                return $"Squirrel: Ill eat the {request.ToString()}.\n";
            else
                return base.Handle(request);
        }
    }

    public class DogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Bone")
                return $"Dog: Ill eat the {request.ToString()}.\n";
            else
                return base.Handle(request);
        }
    }

    public class CoRClient
    {
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                    Console.WriteLine($"{result}");
                else
                    Console.WriteLine($"{food} was left untouched.");
            }
        }
    }
}
