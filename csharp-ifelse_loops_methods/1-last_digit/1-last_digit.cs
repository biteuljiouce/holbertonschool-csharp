using System;

//  assign a random signed number to the variable number each time it is executed.

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastDigit = number % 10;
        string str = "";
        if (number > 5)
        {
            str = "and is greater than 5";
        }
        else if (number < 6 && number != 0)
        {
            str = "and is less than 6 and not 0";
        }
        else if (number == 0)
        {
            str = "and is 0";
        }
        Console.WriteLine($"The last digit of {number} is {lastDigit} {str}");
    }
}