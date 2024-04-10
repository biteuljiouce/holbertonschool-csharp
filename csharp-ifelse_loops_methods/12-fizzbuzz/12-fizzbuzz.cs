using System;


class Program
{
    static void Main(string[] args)
    {
        string str = "";
        int max = 100;
        for (int i = 1; i <= max; i++)
        {
            if (i % 3 == 0)
            {
                if (i % 5 == 0)
                    str = "FizzBuzz";
                str = "Fizz";
            }
            else if (i % 5 == 0)
                str = "Buzz";
            else
                str = i.ToString();
            Console.Write($"{str}");
            if (i < max)
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}
