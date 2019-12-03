using System;

public class Array2D_Demo
{
    static void Main()
    {
        int [,] matrix = new int[,]
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        Console.WriteLine("Displaying seven : " + matrix[2,0]);
    }

}