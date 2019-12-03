using System;

class Array3D_Demo
{
    static void Main(string []args)
    {
        int [,,]array3D = new int[,,]
        {
            {
                {12,34,53},{45,23,74}
            },
            {
                {19,36,73},{81,63,62}
            }
        };

        Console.WriteLine("Displaying eighty one : " + array3D[1,1,0]);
    }
}