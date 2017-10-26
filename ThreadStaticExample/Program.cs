using System;
using System.Threading;

namespace ThreadStaticExample
{
    class Program
    {
        [ThreadStatic]
        public static int _field;

        public static void Main()
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine($"Thread A: {_field}");
                }
            }).Start();
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine($"Thread B: {_field}");
                }
            }).Start();
            Console.ReadKey();
        }
    }
}
