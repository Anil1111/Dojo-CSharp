using System;

public class ForEachLoopDemo
{
    static void Main()
    {
        string []names = {"Sam","Jimmy","Amanda","Wilson","Rhonda","Julia","Mike"};
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}