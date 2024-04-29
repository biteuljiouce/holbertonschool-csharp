using System;
using System.Collections.Generic;

class List
{
    // prints n elements of a list.
    public static int SafePrint(List<int> myList, int n)
    {
        int i = 0;
        try
        {
            while (i < n)
            {
                Console.WriteLine(myList[i]);
                i++;
            }
        }
        catch (Exception)
        {
            // Don't catch an exception unless you can handle it and leave the application in a known state. If you catch System.Exception, rethrow it using the throw keyword at the end of the catch block.
        }
        return i;
    }
}
