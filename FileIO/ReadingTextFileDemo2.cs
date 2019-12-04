using System;

public class ReadingTextFileDemo2
{
    static void Main(string []args)
    {
        string []text = System.IO.File.ReadAllLines(@"Earth.txt");
        foreach(string t in text)
        {
            Console.WriteLine(t);
        }
    }
}