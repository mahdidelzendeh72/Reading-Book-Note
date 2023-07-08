namespace DecoratorDesignPattern.middleware
{
    // Define a concrete implementation of the middleware
    public class AuthenticationMiddleware : IMiddleware
    {
        private readonly IMiddleware _nextMiddleware;

        public AuthenticationMiddleware(IMiddleware nextMiddleware)
        {
            _nextMiddleware = nextMiddleware;
        }

        public void Execute(string data)
        {
            // Perform authentication logic here
            Console.WriteLine("Authenticating...");
            // Call the next middleware in the chain
            _nextMiddleware.Execute(data);
        }
    }

}
