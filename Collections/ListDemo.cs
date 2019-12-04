using System;
using System.Collections.Generic;
public class ListDemo
{
    static void Main(string []args)
    {
        List<int> list = new List<int> {3,6,12,74,23,1,8,45,9};
        list.Sort();
        foreach(int num in list)
        {
            Console.WriteLine(num);
        }
        list.Add(91);
        list.Add(34);
        Console.WriteLine("----------------------------");
        foreach(int num in list)
        {
            Console.WriteLine(num);
        }

    }
}