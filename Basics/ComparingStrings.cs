using System;

class ComparingStrings
{
    static void Main(String []args)
    {
        String name1 = "Sam";
        String name2 = "Sam";
        Console.WriteLine(name1.Equals(name2));
        Console.WriteLine(name1.CompareTo(name2));
    }
}