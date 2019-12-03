using System;

abstract class SomeClass
{
    public void info1() 
    {
        Console.WriteLine("This information is coming from SomeClass.");
    }

    abstract public void info2();
    abstract public void info3();
    abstract public void info4();
}

abstract class Inheritor:SomeClass
{
    public override void info2()
    {
        Console.WriteLine("This information is coming from Inheritor.");
    }

    public override void info3()
    {
        Console.WriteLine("This information is also coming from Inheritor.");
    }

    abstract public override void info4();
}

class Inheritor2:Inheritor
{
    public override void info4()
    {
        Console.WriteLine("This information is coming from Inheritor2.");
    }
}

public class AbstractClassDemo2
{
    static void Main(string []args)
    {
        Inheritor2 inh2 = new Inheritor2();
        inh2.info1();
        inh2.info2();
        inh2.info3();
        inh2.info4();
    }
}