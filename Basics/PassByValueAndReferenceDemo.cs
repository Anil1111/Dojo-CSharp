using System;

class PassByValueAndReferenceDemo
{
    static void setNum(ref int num)
    {
        num = 45;
    }

    static void Main()
    {
        int num = 64;
        setNum(ref num);
        Console.WriteLine("Number is : "+num);
    }
}