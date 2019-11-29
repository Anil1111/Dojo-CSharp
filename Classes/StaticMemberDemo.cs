
using System;
class SomeClass
{
    public static int COUNT;
    public SomeClass()
    {
        COUNT++;
    }
}

class StaticMemberDemo
{
    static void Main(string []args)
    {
        SomeClass sc1 = new SomeClass();
        SomeClass sc2 = new SomeClass();
        SomeClass sc3 = new SomeClass();

        Console.WriteLine(SomeClass.COUNT);
    }
}