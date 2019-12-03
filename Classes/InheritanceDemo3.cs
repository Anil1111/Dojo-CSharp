using System;

class Games
{
    protected string gameTitle;
    protected string publisher;
    public Games(){}
    protected Games(string gameTitle, string publisher)
    {
        this.gameTitle = gameTitle;
        this.publisher = publisher;
    }

}

class Platform :Games
{
    private double gamePrice;
    private string platform;
    
    public Platform(string gameTitle, string publisher, double gamePrice, string platform)
    {
        this.gameTitle = gameTitle;
        this.gamePrice = gamePrice;
        this.gamePrice = gamePrice;
        this.platform = platform;
    }

    public override string ToString()
    {
        return gameTitle + " has been published by " + publisher + " for " + platform + " and sold at a price of " + gamePrice;
    }

}

public class InheritanceDemo3
{
    static void Main(string []args)
    {
        Platform pc = new Platform("Destiny 2", "Bungie", 2999.99, "PC");
        Platform ps4 = new Platform("God of War", "Santa Monica", 3999.99, "PS4");

        Console.WriteLine(pc);
        Console.WriteLine(ps4);
    }
}