using System;
using System.Threading;

class ThreadDemo1
{
    static void Main(string []args)
    {
        Console.WriteLine("The line will be printed after 5 seconds.");
        Thread.Sleep(5000);
        Console.WriteLine("This is the next line.");
    }
}