namespace DecoratorDesignPattern.middleware
{
    // Define the base interface for the middleware
    public interface IMiddleware
    {
        void Execute(string data);
    }

}
