using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WithoutAsyncAwaitNamespace
{
    class Program
    {
        static void Main()
        {
            Task task = PerfomTaskWithoutAsyncAwait();
            task.Wait();
            Console.WriteLine("Main method complted");

            Console.ReadLine();
        }

        static Task PerfomTaskWithoutAsyncAwait()
        {
            Console.WriteLine("Performing tasks without async/await.");

            //JS Filter and find
            Task<int> task1 = Task.Run(() => PerformComputation(10, 20)); //30

            Task<int> task2 = Task.Run(() => PerformComputation(100, 200)); // 300

            return Task.WhenAll(task1, task2).ContinueWith((rTask) =>
              {
                  int result1 = task1.Result;
                  int result2 = task2.Result;
                  Console.WriteLine(result1);
                  Console.WriteLine(result2);
                  Console.WriteLine(rTask);
              });
        }

        static int PerformComputation(int a, int b)
        {
            Console.WriteLine($"Perform addition for {a} and {b}");
            Thread.Sleep(2000);
            return a + b;
        }

    }
}
