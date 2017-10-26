using System;
using System.Linq;

namespace AsParallelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0).ToArray();
            var orderedResult = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0).ToArray();
            parallelResult.ToList().ForEach(i => Console.WriteLine(i));
            Console.WriteLine("Ordered: ");
            orderedResult.Take(5).ToList().ForEach(i => Console.WriteLine(i));
            Console.ReadLine();
        }
    }
}
