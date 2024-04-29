using System;
using System.Collections.Generic;

class List
{
    // prints n elements of a list.
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        /*
        if (n > myList.Count)
        {
            throw new ArgumentException("Error : n is bigger than list length.");
        }
        if (myList == null)
        {
            throw new ArgumentException("Error : myList cannot be null.");
        }*/
        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                count = i + 1;
            }
        }
        catch (IndexOutOfRangeException e)
        {
        }
        catch (ArgumentOutOfRangeException e)
        {
        }
        return count;
    }
}

