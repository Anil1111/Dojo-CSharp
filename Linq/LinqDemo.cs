using System;
using System.Collections.Generic;
using System.Linq;
class LinqDemo
{
    static void Main(string []args)
    {
        int []number = new int[]{56,23,73,84,24,84,44,67,64,23,84,45,74};
        oddNumbers(number);
    }

    static void oddNumbers(int[] number)
    {
        IEnumerable<int> oddNums = from num in number where num % 2 != 0 select num;
        foreach(int i in oddNums)
        {
            System.Console.WriteLine(i);
        }
    }
}