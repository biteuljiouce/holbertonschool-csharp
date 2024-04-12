﻿using System;
using System.Collections.Generic;


class List
{
    // deletes the item at a specific position in a list.
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index >= myList.Count && index < 0)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }
        myList.Remove(myList[index]);
        return myList;
    }
}
