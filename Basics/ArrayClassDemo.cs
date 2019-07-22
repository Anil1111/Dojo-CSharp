using System;

class ArrayClassDemo
{
    private static void sortA(string []names)
    {
        Array.Sort(names);
        foreach(String s in names)
        {
            Console.WriteLine(s);
        }
    }

    private static void reverseList(string []names)
    {
        Array.Reverse(names);
        foreach(String s in names)
        {
            Console.WriteLine(s);
        }
    }
    static void Main()
    {
        string []names = {"Sam","James","Mike","John","Amanda","Julia","Rhonda","Aaron"};
        sortA(names);
        reverseList(names);
    }
}