using System;

public class DateTimeDemo2
{
    static void Main(string []args)
    {
        DateTime dt = DateTime.Today.AddDays(1);
        dt.AddDays(1);
        Console.WriteLine(DateTime.Today);
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(dt);
    }    
}