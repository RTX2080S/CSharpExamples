using System;

namespace UisngDelegate
{
    class Program
    {
        delegate int Calculate(int x, int y);

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4)); // Displays 7
            calc = Multiply;
            Console.WriteLine(calc(3, 4)); // Displays 12
            // Using lambda
            calc = (x, y) => x - y;
            Console.WriteLine(calc(3, 4)); // Displays -1
            calc = (x, y) => { return x + y; };
            Console.WriteLine(calc(3, 4)); // Displays 7
            Console.ReadKey();
        }
    }
}
