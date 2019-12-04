using System;

public class ReadingTextFileDemo
{
    static void Main(string []args)
    {
        string text = System.IO.File.ReadAllText(@"Earth.txt");
        Console.WriteLine("The content of the file is : "+ text);
    }
}