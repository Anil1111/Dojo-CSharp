using System;

public class TryParseDemo
{
    static void Main(string []args)
    {
        string num = "123a";
        int number = 0;
        if(int.TryParse(num,out number))
        {
            Console.WriteLine("Number parsed successfully : " + number);
        } 
        else
        {
            Console.WriteLine("Parsing failed.");
        }
    }
}