using System;

public class RandomDemo
{
    static void Main(string []args)
    {
        Random rand = new Random();
        int num = rand.Next(1,6);
        Console.WriteLine("Dice rolled at : " + num);
    }
}