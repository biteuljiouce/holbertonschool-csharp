﻿using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        if (number < 0)
            number = number * -1;
        int lastDigit = number % 10;
        Console.Write(lastDigit.ToString());
        return (lastDigit);
    }
}
