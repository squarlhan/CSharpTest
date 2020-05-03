using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadandTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task with thread start!");
            for(int i = 0; i<=15; i++)
            {
                Thread t = new Thread(doSth);
                t.Start();
            }
            Console.WriteLine("Task with thread stop!");

            Console.WriteLine("Task with task start!");
            for (int i = 0; i <= 15; i++)
            {
                Task t = new Task(doSth);
                t.Start();
                t.Wait();
            }
            Console.WriteLine("Task with task stop!");
        }

        public static void doSth()
        {
            Thread.Sleep(500);
            Task.Delay(500);
            Console.WriteLine("Task has been done! ThreadID: {0}, isBackGround: {1}.",
                Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground);
        }
    }
}
