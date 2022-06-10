﻿namespace DesignPatterns.Structural.Adapter
{
    public interface ITarget
    {
        string GetRequest();
    }


    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request";
        }
    }

    public class Adapter: ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee =  adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}
