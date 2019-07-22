using System;

class PointerDemo
{
    static unsafe void Main()
    {
        int num = 56;
        int *ptr = &num;
        Console.WriteLine("Value of num is      : " + num);
        Console.WriteLine("Address of num is    : " + (uint)&num);
        Console.WriteLine("Value of ptr         : " + (uint)ptr);
        Console.WriteLine("Address of ptr       : " + (uint)&ptr);
        Console.WriteLine("Reference value      : " + *ptr);
    }
}