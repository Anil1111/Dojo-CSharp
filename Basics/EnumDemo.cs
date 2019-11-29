using System;
class EnumDemo
{
    enum DayOfWeek
    {
        SUNDAY,
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY
    }
    static void Main(string []args)
    {
        DayOfWeek today = DayOfWeek.SATURDAY;
        Console.WriteLine(today);
    }
}