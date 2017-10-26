using System;
using System.Threading;

namespace CSharpExamples
{
    class Program
    {
        static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(0);
            }
        }

        static void Main(string[] args)
        {
            var t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();
            Console.ReadKey();
        }
    }
}
