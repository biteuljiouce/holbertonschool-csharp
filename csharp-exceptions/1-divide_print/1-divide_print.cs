using System;


class Int
{
    // divides 2 integers and prints the result.
    public static void divide(int a, int b)
    {
        int result = 0;
        try
        {
            result = a / b;
        }
        catch (Exception ex)
        {
            // Console.WriteLine(ex.ToString());
            Console.WriteLine("Cannot divide by zero", ex.Message);
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {result}");
        }
    }
}

