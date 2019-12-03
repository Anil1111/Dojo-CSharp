using System;
using System.Collections;

public class ArrayListDemo2
{
    static void Main(string []args)
    {
        ArrayList myList = new ArrayList();
        myList.Add("Sam");
        myList.Add(47);
        myList.Add(12.53);
        myList.Add(true);

        foreach(var s in myList)
        {
            Console.WriteLine(s);
        }
    }
}