using System;
class Bank
{
    private double money;
    private string owner;

    public Bank(double money, string owner)
    {
        this.money = money;
        this.owner = owner;
    }

    public double Money
    {
        get
        {
            return money;
        }
    }

    public string Owner
    {
        get
        {
            return owner;
        }
    }

    public static Bank operator +(Bank b1, Bank b2)
    {
        double amount  = b1.Money + b2.Money;
        string newOwner = b1.Owner + " " + b2.Owner;
        return new Bank(amount, newOwner);
    }
}

class OperatorOverloadingDemo
{
    static void Main(string []args)
    {
        Bank b1 = new Bank(150.12,"Sam");
        Bank b2 = new Bank(120.3,"Paul");
        Bank b3 = b1 + b2;

        Console.WriteLine("New Owner : " + b3.Owner);
        Console.WriteLine("Amount    : " + b3.Money);
    }
}