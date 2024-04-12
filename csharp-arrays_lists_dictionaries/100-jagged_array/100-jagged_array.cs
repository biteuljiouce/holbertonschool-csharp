using System;
using System.Collections.Generic;

// creates and prints a 5 by 5 two-dimensional array and initialize index [2,2] to 1 and all other indices to 0.
class Program
{
    static void Main(string[] args)
    {
        int[][] jagged =
        {
            new int[] {0, 1, 2, 3},
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0, 1}
        };
        string msge = "";
        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
                msge += jagged[i][j] + " ";
            msge = msge.Substring(0, msge.Length - 1) + '\n';
        }
        Console.Write(msge);
    }
}