using System;
public interface ISomeInterface
{
    void info1();
    void info2();
}

public class Inheriter:ISomeInterface
{
    public void info1()
    {
        Console.WriteLine("This is info 1.");
    }

    public void info2()
    {
        Console.WriteLine("This is info 2.");
    }
}

public class InterfaceDemo
{
    static void Main(string []args)
    {
        new Inheriter().info1();
        new Inheriter().info2();
    }
}