using System;
abstract class SomeClass
{
    public void info1()
    {
        Console.WriteLine("This is info 1.");
    }

    abstract public void info2();
    abstract public void info3();
}

class Inheritor:SomeClass
{
    public override void info2()
    {
        Console.WriteLine("This is info 2.");
    }

    public override void info3()
    {
        Console.WriteLine("This is info 3.");
    }
}

public class AbstractClassDemo
{
    static void Main(string []args)
    {
        Inheritor inh = new Inheritor();
        inh.info1();
        inh.info2();
        inh.info3();
    }
}