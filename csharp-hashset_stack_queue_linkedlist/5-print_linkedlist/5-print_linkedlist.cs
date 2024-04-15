using System;
using System.Collections.Generic;

class LList
{
    // creates and prints a LinkedList of integers of a given size.
    public static LinkedList<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            return new LinkedList<int>();
        }
        LinkedList<int> llist = new LinkedList<int>();
        for (int i = 0; i < size; i++)
        {
            llist.AddLast(i);
            Console.WriteLine(i);
        }
        return llist;
    }
}
