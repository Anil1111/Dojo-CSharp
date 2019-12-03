using System;
using System.Collections;

public class ArrayListDemo
{
    static void Main(string []args)
    {
        ArrayList myList = new ArrayList();
        myList.Add("Sam");
        myList.Add("Michael");
        myList.Add("Jonathan");
        myList.Add("Amanda");

        foreach(string s in myList)
        {
            Console.WriteLine(s);
        }
    }
}