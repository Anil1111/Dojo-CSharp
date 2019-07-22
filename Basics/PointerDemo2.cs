using System;

class PointerDemo2
{
    static unsafe void Main()
    {
        int num = 45;
        int *ptr = &num;
        Console.WriteLine("Value of num     : "+num);
        *ptr = 97;
        Console.WriteLine("Value of num     : "+num);
    }
}