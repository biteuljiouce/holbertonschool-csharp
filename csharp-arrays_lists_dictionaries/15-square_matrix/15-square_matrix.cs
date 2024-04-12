using System;
using System.Collections.Generic;

class Matrix
{
    // computes the square value of all integers of a matrix.
    public static int[,] Square(int[,] myMatrix)
    {
        int[,] squares = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];
        squares = myMatrix;
        for (int x = 0; x < myMatrix.GetLength(0); x++)
        {
            for (int y = 0; y < myMatrix.GetLength(1); y++)
            {
                squares[x, y] = squares[x, y] * squares[x, y];
            }
        }
        return squares;
    }
}
