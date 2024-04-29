using System;


class Int
{
    // divides 2 integers and prints the result.
    public static void divide(int a, int b)
    {
        float result = 0;
        try
        {
            result = a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (Exception ex)
        {

        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {result}");
        }
    }
}

