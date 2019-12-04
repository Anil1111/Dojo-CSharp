using System;

class Master
{
    public virtual void info()
    {
        Console.WriteLine("This information is coming from the Master class.");
    }
}

class Slave:Master
{
    public override sealed void info() // Sealed ensures that sealed cannot be further overridden.
    {
        Console.WriteLine("This information is coming from the Slave class.");
    }
}

public class SealedDemo
{
    static void Main(string []args)
    {
        Slave slave = new Slave();
        slave.info();
    }
}