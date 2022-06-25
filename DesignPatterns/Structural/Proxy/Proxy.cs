namespace DesignPatterns.Structural.Proxy
{
    public interface ISubject
    {
        void Request();
    }

    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling request.");
        }
    }

    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        public void Request()
        {
            if (this.CheckAccess())
            {
                _realSubject.Request();
                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");
            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }

    public class ProxyClient
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}
