using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace DesignPatterns.HelloWorld
{
    [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            new HelloWorld("Gary");
        }

        public HelloWorld(string person)
        {
            SayHello(person);
        }

        private static void SayHello(string person)
        {
            Debug.WriteLine($"Hello, {person}");
        }
    }
}