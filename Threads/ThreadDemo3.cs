using System;
using System.Threading;
using System.Threading.Tasks;
class ThreadDemo3
{
    static void Main(string []args)
    {
        var taskCompletionSource = new TaskCompletionSource<bool>();
        var thread = new Thread(()=>
        {
            Console.WriteLine("Thread has started.");
            Thread.Sleep(2000);
            Console.WriteLine("Thread has ended.");
            taskCompletionSource.TrySetResult(true);
        });
        Console.WriteLine("Thread number is : {0}",Thread.CurrentThread.ManagedThreadId);
        thread.Start();

        var test = taskCompletionSource.Task.Result;
    }
}