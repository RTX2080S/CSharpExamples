using System;
using System.Threading.Tasks;

namespace TaskContinuation
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() => { return 10; });
            t.ContinueWith((i) => { Console.WriteLine("Cancelled"); }, TaskContinuationOptions.OnlyOnCanceled);
            t.ContinueWith((i) => { Console.WriteLine("Faulted"); }, TaskContinuationOptions.OnlyOnFaulted);
            var completedTask = t.ContinueWith((i) => { Console.WriteLine("Completed"); }, TaskContinuationOptions.OnlyOnRanToCompletion);
            completedTask.Wait();
            Console.ReadKey();
        }
    }
}
