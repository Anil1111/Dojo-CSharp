using System;

class Master
{
    public void info()
    {
        Console.WriteLine("This information is coming from the Master class.");
    }

}

class Slave : Master
{
    public new void info()
    {
        Console.WriteLine("This information is coming from the Slave Class.");
    }
}

public class NewFunctionDemo
{
    static void Main(string []args)
    {
        Master slave = new Slave();
        slave.info();
    }
}