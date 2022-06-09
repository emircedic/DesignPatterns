namespace DesignPatterns.Singleton.SingletonNonThreadSafe
{
    public sealed class SingletonNonThreadSafe
    {
        private SingletonNonThreadSafe() { }

        public static SingletonNonThreadSafe _instance { get; set; }

        public static SingletonNonThreadSafe GetInstance()
        {
            if (_instance == null)
                _instance = new SingletonNonThreadSafe();

            return _instance;
        }

        public void SomeBussinessLogic() { }
    }
}
