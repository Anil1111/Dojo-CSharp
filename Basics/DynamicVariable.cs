using System;

class DynamicVariable
{
    static void Main()
    {
        dynamic dynVar = true;
        Console.WriteLine("Value : {0}, Type {1}",dynVar,dynVar.GetType().ToString());
        dynVar = 453.23;
        Console.WriteLine("Value : {0}, Type {1}",dynVar,dynVar.GetType().ToString());
        dynVar = "Sam";
        Console.WriteLine("Value : {0}, Type {1}",dynVar,dynVar.GetType().ToString());
    }
}