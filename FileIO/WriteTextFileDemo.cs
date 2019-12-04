using System;

class WriteTextFileDemo
{
    static void Main(string []args)
    {
        string []lines = {"Mars is the fourth planet of our Solar System", "This planet is also known as the Red planet"};
        System.IO.File.WriteAllLines(@"Mars.txt",lines);
    }
}