using System;

public class OutDemo2
{
    private static void getInfo(out string name, out int rollNo)
    {
        name = "Sam Paul";
        rollNo = 34;
    }

    public static void Main()
    {
        int rollNo;
        string name;
        getInfo(out name, out rollNo);
        Console.WriteLine("Name         : "+name);
        Console.WriteLine("Roll No      : "+rollNo);
    }
}