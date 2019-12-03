using System;

class ArrayAsParameterDemo
{
    static void showNum(int []num)
    {
        foreach(int n in num)
        {
            Console.WriteLine(n);
        }
    }
    static void Main(string []args)
    {
        int []num = {56,34,23,84,95,23,73};
        showNum(num);
    }    
}