using System;

public class DelegateDemo2
{
    public delegate void Events();

    public static void Event1()
    {
        Console.WriteLine("Event 1 has been triggered.");
    }

    public static void Event2()
    {
        Console.WriteLine("Event 2 has been triggered.");
    }

    static void Main(string []args)
    {
        Events evt1 = Event1;
        Events evt2 = Event2;
        Events evt = evt1+evt2;
        evt();
    }
    
}