using System;

class Master
{
    public virtual void info()
    {
        Console.WriteLine("This information is coming from the Master Class.");
    }
}

class Slave:Master
{
    public override void info()
    {
        Console.WriteLine("This information is coming from the Slave Class.");
    }
}

public class VirtualDemo
{
    static void Main(string []args)
    {
        Master master = new Slave();
        master.info();
    }
}