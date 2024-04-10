using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            string end = ", ";
            for (int i = 0; i <= 9; i++)
            {
                for (int j = i + 1; j <= 9; j++)
                {
                    if ($"{i}{j}" == "89")
                    {
                        end = "\n";
                    }
                    Console.Write($"{i}{j}{end}");
                }
            }
        }
    }
}
