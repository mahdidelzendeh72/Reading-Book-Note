namespace DecoratorDesignPattern.middleware
{
    // Define another concrete implementation of the middleware
    public class LoggingMiddleware : IMiddleware
    {
        private readonly IMiddleware _nextMiddleware;

        public LoggingMiddleware(IMiddleware nextMiddleware)
        {
            _nextMiddleware = nextMiddleware;
        }

        public void Execute(string data)
        {
            // Perform logging logic here
            Console.WriteLine("Logging...");
            // Call the next middleware in the chain
            _nextMiddleware.Execute(data);
        }
    }

}
