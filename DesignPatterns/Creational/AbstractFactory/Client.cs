namespace DesignPatterns.AbstractFactory
{
    public static class ClientAbstractFactory
    {
        public static void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productA.UserfulFunctionA());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
