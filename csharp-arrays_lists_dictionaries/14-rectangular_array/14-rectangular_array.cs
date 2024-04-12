using System;
using System.Collections.Generic;

// creates and prints a 5 by 5 two-dimensional array and initialize index [2,2] to 1 and all other indices to 0.
class Program
{
    static void Main(string[] args)
    {
        int dimension = 5;
        int[,] theMatrix = new int[dimension, dimension];
        string msge;

        theMatrix[2, 2] = 1;

        for (int x = 0; x < dimension; x++)
        {
            msge = "";
            for (int y = 0; y < dimension; y++)
            {
                msge += $"{theMatrix[x, y]} ";
            }
            msge = msge.Substring(0, msge.Length - 1);
            Console.WriteLine(msge);
        }
    }
}