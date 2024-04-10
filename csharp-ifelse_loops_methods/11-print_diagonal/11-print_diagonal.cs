using System;


class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length > 0)
            for (int i = 0; i < length; i++)
            {
                for (int sp = 0; sp < i; sp++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                Console.WriteLine();
            }
        else
            Console.WriteLine();
    }
}
