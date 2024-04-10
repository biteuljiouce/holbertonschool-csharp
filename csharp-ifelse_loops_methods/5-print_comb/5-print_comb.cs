using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            string end = ", ";
            for (int i = 0; i <= 99; i++)
            {
                if (i == 99)
                {
                    end = "\n";
                }
                Console.Write($"{i:D2}{end}");
            }
        }
    }
}
