using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace EnumeratingConcurrentBag
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Task.Run(() =>
            {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });
            Task.Run(() =>
            {
                // Pause for a short while to allow for 42 added into the bag
                Thread.Sleep(10);
                foreach (int i in bag)
                    Console.WriteLine(i);
            }).Wait();

            Console.ReadKey();
            // Displays
            // 42
            // This code only displays 42 because the other value is added after iterating over the bag has started
        }
    }
}
