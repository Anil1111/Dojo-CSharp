using System;

class MethodDemo2
{
    static void greet(string name)
    {
        Console.WriteLine("Hello "+name);
    }
    static void Main()
    {
        greet("Sam");
        greet("Mike");
        greet("Amanda");

    }
}
