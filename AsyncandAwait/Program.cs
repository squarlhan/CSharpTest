using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncandAwait
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("task {0}: Task Start !", Thread.CurrentThread.ManagedThreadId);
            //DotaskWithThread();
            var task = DOTaskWithAsync();
            Console.WriteLine("Thread {0}: Task End !", Thread.CurrentThread.ManagedThreadId);
            task.Wait();
        }

        public static async Task DOTaskWithAsync()
        {
            Console.WriteLine("Thread {0}: Await Taskfunction Start", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i <= 10; i++)
            {
                await Task.Run(() =>
                {

                    Thread.Sleep(1000);
                    Console.Write($"task {i}:");
                    Dotaskfunction();

                });
            }
            Console.WriteLine("Thread {0}: Await Taskfunction Stop!", Thread.CurrentThread.ManagedThreadId);

        }
        public static void Dotaskfunction()
        {
            for (int i = 0; i <= 0; i++)
            {

                Console.WriteLine("Thread {0} has been done!", Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
