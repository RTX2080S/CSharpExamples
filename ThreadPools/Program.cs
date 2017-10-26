using System;
using System.Threading;

namespace ThreadPools
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            Console.ReadKey();
        }
    }
}
