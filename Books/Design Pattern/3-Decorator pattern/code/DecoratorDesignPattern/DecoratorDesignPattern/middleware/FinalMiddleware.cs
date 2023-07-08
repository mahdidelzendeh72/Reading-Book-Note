namespace DecoratorDesignPattern.middleware
{
    // Define the final implementation of the middleware
    public class FinalMiddleware : IMiddleware
    {
        public void Execute(string data)
        {
            // Perform final logic here
            Console.WriteLine("Final middleware executing...");
        }
    }

}
