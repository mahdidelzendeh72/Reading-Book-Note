using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace DecoratorDesignPattern.example
{
    /// Here's an example of how you can use a logging library like Serilog to add logging functionality to existing classes or methods in C#:

    public class Calculator
    {
        private readonly ILogger _logger;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        public int Add(int a, int b)
        {
            _logger.Information("Adding {a} and {b}", a, b);
            int result = a + b;
            _logger.Information("Result: {result}", result);
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Configure Serilog logger
            Log.Logger = new LoggerConfiguration()
                .CreateLogger();

            // Create an instance of the Calculator class with Serilog logger
            var calculator = new Calculator(Log.Logger);

            // Call the Add method, which will log the operation and result
            int sum = calculator.Add(5, 3);

            // Output the result
            Console.WriteLine("Sum: " + sum);

            // Dispose the logger
            Log.CloseAndFlush();
        }
    }


//In this example, we have a `Calculator` class that performs addition.We want to add logging functionality to this class using the Serilog logging library.

//First, we configure the Serilog logger in the `Main` method.We specify that the log messages should be written to the console.

//Next, we create an instance of the `Calculator` class and pass the Serilog logger to its constructor.

//Inside the `Add` method of the `Calculator` class, we use the `_logger` instance to log the operation and result of the addition.

//Finally, we call the `Add` method and output the result.The log messages will be displayed in the console due to the Serilog configuration.

//By using the Serilog logger as a decorator or wrapper around the `Calculator` class, we are able to add logging functionality without modifying the core behavior of the class. This allows us to easily add or remove logging from different parts of our application as needed.
}
