using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Task task = new Task(() => PrintNumbersInRange(n));
        //Thread task = new Thread(() => PrintNumbersInRange(n));
        task.Start();
        PrintNumbersInRange(n / 2);
        Console.WriteLine("Main thread is done");
        task.Wait();
    }
    private static void PrintNumbersInRange(int bound)
    {
        for (int i = 0; i <= bound; i++)
        {
            Console.WriteLine("{0} print {1}", Thread.CurrentThread.ManagedThreadId, i);
        }
        Console.WriteLine("Thread {0} is done", Thread.CurrentThread.ManagedThreadId);
        //Console.ReadLine();
    }
}