using System;
using System.Threading.Tasks;

namespace TaskFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int[]> parent = Task.Run(() =>
            {
                var results = new int[3];
                var factory = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);
                factory.StartNew(() => results[0] = 0);
                factory.StartNew(() => results[1] = 1);
                factory.StartNew(() => results[2] = 2);
                return results;
            });
            var finalTask = parent.ContinueWith(
            (parentTask) =>
            {
                foreach (int i in parentTask.Result)
                    Console.WriteLine(i);
            });
            finalTask.Wait();
            Console.ReadKey();
        }
    }
}
