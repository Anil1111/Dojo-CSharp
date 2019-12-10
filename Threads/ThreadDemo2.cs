using System;
using System.Threading;

class ThreadDemo2
{
    static void Main(string []args)
    {
        new Thread(()=>
        {
            Console.WriteLine("Thread 1 has started.");
            Thread.Sleep(1000);
            System.Console.WriteLine("Thread 1 has ended.");
        }).Start();

        new Thread(()=>
        {
            Console.WriteLine("Thread 2.");
            Thread.Sleep(1000);
            System.Console.WriteLine("Thread 2 has ended.");
        }).Start();

        new Thread(()=>
        {
            Console.WriteLine("Thread 3.");
            Thread.Sleep(1000);
            System.Console.WriteLine("Thread 3 has ended.");
        }).Start();

        new Thread(()=>
        {
            Console.WriteLine("Thread 4.");
            Thread.Sleep(1000);
            System.Console.WriteLine("Thread 4 has ended.");
        }).Start();

    }
}