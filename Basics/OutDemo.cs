using System;
class OutDemo
{
    public static void changeValue(out int num)
    {
        num = 0;
        num = num+5;
    }
    static void Main(string []args)
    {
        int num;
        changeValue(out num); // out allows passing reference to variable which is uninitialized.
        Console.WriteLine(num);
    }
}