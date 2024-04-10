using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        string str = "zero";
        if (number > 0)
        {
            str = "positive";
        }
        else if (number < 0)
        {
            str = "negative";
        }
        Console.WriteLine($"{number} is {str}");
    }
}
