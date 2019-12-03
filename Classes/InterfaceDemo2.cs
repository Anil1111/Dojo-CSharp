using System;

public interface IVirus
{
    void info1();
    void info2();
    void info3();

}

abstract class InfectedHost:IVirus
{
    public void info1()
    {
        Console.WriteLine("This is info 1.");
    }

    public void info2()
    {
        Console.WriteLine("This is info 2.");
    }

    abstract public void info3();
}

class AnotherInfectedHost:InfectedHost
{
    public override void info3()
    {
        Console.WriteLine("This is info 3.");
    }
}

public class InterfaceDemo2
{
    static void Main(string []args)
    {
        AnotherInfectedHost aih = new AnotherInfectedHost();
        aih.info1();
        aih.info2();
        aih.info3();
    }
}