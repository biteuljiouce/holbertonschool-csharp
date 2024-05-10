using System;

namespace MyMath
{

    /// <summary>
    /// Math operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Add 2 numbers
        /// </summary>
        /// <returns>The sum of two integers</returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Divides a matrix by an int.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="num"></param>
        /// <returns>divided matrix</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int[,] result = new int[row, col];
            try
            {
                for (int i = 0; i < row; i++)
                    for (int j = 0; j < col; j++)
                    {
                        result[i, j] = matrix[i, j] / num;
                    }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Num cannot be 0", e);
                return null;
            }
            return result;
        }
    }
}