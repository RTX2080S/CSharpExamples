using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace BlockingCollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                // This would be the same with GetConsumingEnumerable()
                //while (true)
                //    Console.WriteLine(col.Take());

                // This would be the same with the above while statement
                foreach (string v in col.GetConsumingEnumerable())
                    Console.WriteLine(v);
            });
            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    col.Add(s);
                }
            });
            write.Wait();
        }
    }
}
