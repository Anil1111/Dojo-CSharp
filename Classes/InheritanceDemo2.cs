using System;

class MasterClass
{
    public MasterClass()
    {
        Console.WriteLine("Master Class Constructor.");
    }
    public void info()
    {
        Console.WriteLine("This information is coming from the master class.");
    }
}

class Slave :MasterClass
{
    public Slave()
    {
        Console.WriteLine("Slave class constructor.");
    }
}

public class InheritanceDemo2
{
    static void Main(string []args)
    {
        Slave slave = new Slave();
        slave.info();
    }
}