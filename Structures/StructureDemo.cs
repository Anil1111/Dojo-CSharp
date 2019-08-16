using System;

struct GamesLib
{
    public string title;
    public int price;
    public string platform;
    public string genre;
};

public class StructureDemo
{
    static void Main()
    {
        GamesLib gow;
        Console.Write("Enter title      : ");
        gow.title = Console.ReadLine();
        Console.Write("Enter price      : ");
        gow.price = int.Parse(Console.ReadLine());
        Console.Write("Enter platform   : ");
        gow.platform = Console.ReadLine();
        Console.Write("Enter Genre      : ");
        gow.genre = Console.ReadLine();

        Console.WriteLine("Game Title       : " + gow.title);
        Console.WriteLine("Game Price       : " + gow.price);
        Console.WriteLine("Platform         : " + gow.platform);
        Console.WriteLine("Genre            : " + gow.genre);
    }
}