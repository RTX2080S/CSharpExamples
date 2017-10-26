using System;
using System.Linq;

namespace AggregateExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel().Where(i => IsEven(i));
                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException e)
            {
                Console.WriteLine($"There where {e.InnerExceptions.Count} exceptions"); ;
            }
            finally
            {
                Console.ReadKey();
            }
        }

        static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException("i");
            return i % 2 == 0;
        }
    }
}
