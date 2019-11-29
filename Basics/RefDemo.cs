using System;
class RefDemo
{
    public static void changeValue(ref int num)
    {
        num = num+5;
    }
    static void Main(string []args)
    {
        int num = 45;
        changeValue(ref num);
        Console.WriteLine(num);
    }
}