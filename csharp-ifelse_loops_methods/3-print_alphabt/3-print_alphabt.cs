using System;

namespace _2_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            foreach (char letter in alpha)
            {
                if (letter.Equals('q') || letter.Equals('e'))
                {
                    continue;
                }
                Console.Write(letter.ToString());
            }
        }
    }
}
