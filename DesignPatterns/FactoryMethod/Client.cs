namespace DesignPatterns.FactoryMethod
{
    public static class ClientFactoryMethod
    {
        public static void ClientCode(Creator creator)
        {
            var result = creator.SomeOperation();
            Console.WriteLine("I am not aware of the creators class but it still works. \n" + result);
        }
    }
}
