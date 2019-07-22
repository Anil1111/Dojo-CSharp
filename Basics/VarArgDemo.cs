using System;

class VarArgDemo
{
    private static void displayList(params string[] names)
    {
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
    }

    static void Main()
    {
        displayList("Sam","William","Amanda","Julia","Mike","Wilson","Rhonda","Shannon","Aaron","Bill");
    }
}