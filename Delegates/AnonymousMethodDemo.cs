using System;

public class MyClass
{
    public delegate void Event();
    static void Main(string []args)
    {
        Event evt1 = delegate()
        {
            Console.WriteLine("Event 1 has occured.");
        };

        Event evt2 = delegate()
        {
            Console.WriteLine("Event 2 has occured.");
        };
        evt1();
        evt2();

    }
}