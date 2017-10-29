using System;
using System.Linq;

namespace MulticastDelegateExample
{
    class Program
    {
        delegate void Del();

        static void Add()
        {
            Console.WriteLine("Method 1");
        }

        static void Multiply()
        {
            Console.WriteLine("Method 2");
        }

        static void Main(string[] args)
        {
            Del del = Add;
            del += Multiply;

            int invocationCount = del.GetInvocationList().GetLength(0);
            Console.WriteLine($"{invocationCount} methods are registered.");

            Console.WriteLine("Press any key to invoke...");
            Console.ReadKey();
            del();

            Console.ReadKey();
        }
    }
}
