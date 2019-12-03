using System;

class MasterClass
{
    private string someInfo;
    public MasterClass(string someInfo)
    {
        this.someInfo = someInfo;
    }

    public override string ToString()
    {
        return "Class Master has has this info" + someInfo;
    }
}

public class InheritanceDemo
{
    static void Main(string []args)
    {
        Console.WriteLine(new MasterClass("No Info available."));
    }
}