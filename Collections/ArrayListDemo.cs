using System;
using System.Collections;

public class ArrayListDemo
{
    static void Main(string []args)
    {
        ArrayList myList = new ArrayList();
        myList.Add("Sam");
        myList.Add(34);
        myList.Add(false);

        foreach(Object n in myList)
        {
            Console.WriteLine(n);
        }
    }
}