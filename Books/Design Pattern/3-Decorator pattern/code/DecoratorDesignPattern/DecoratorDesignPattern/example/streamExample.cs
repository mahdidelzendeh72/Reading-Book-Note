using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.stream_example
{
    /// Certainly! The `System.IO` namespace in C# provides various classes for working with input and output streams. One of the classes that implements the decorator pattern is the `Stream` class itself.

    ///The `Stream` class is an abstract base class that provides a generic view of a sequence of bytes.It defines the basic operations for reading from and writing to a stream.However, it does not provide the actual implementation for these operations.Instead, it relies on derived classes to provide the specific implementation.


    ///The decorator pattern comes into play when we look at the derived classes of `Stream`. These derived classes, such as `FileStream`, `MemoryStream`, and `NetworkStream`, provide the concrete implementation of the stream operations. They inherit from `Stream` and override its methods to provide the specific behavior for reading from or writing to a particular type of stream.


    ///Here's an example to illustrate how the decorator pattern is used in `System.IO`:

    // Create a FileStream object to read from a file
    public class streamExample
    {

        public void example()
        {

            Stream fileStream = new FileStream("example.txt", FileMode.Open);

            // Wrap the FileStream object with a BufferedStream to add buffering functionality
            Stream bufferedStream = new BufferedStream(fileStream);

            // Wrap the BufferedStream object with a StreamReader to add text reading functionality
            StreamReader streamReader = new StreamReader(bufferedStream);

            // Read the contents of the file using the StreamReader
            string contents = streamReader.ReadToEnd();

            // Close the StreamReader, which will also close the underlying streams
            streamReader.Close();

        }
    }
    ///In this example, we start with a `FileStream` object that represents a stream of bytes from a file. We then wrap this `FileStream` object with a `BufferedStream` object, which adds buffering functionality to improve performance.Finally, we wrap the `BufferedStream` object with a `StreamReader` object, which provides text reading functionality.

    ///Each of these classes acts as a decorator for the underlying stream.They add additional functionality to the stream without modifying its core behavior. This allows us to chain multiple decorators together to create a stream with multiple layers of functionality.

    ///By using the decorator pattern, the `System.IO` namespace provides a flexible and extensible way to work with streams, allowing developers to add or remove functionality as needed without modifying the core stream classes.
}
