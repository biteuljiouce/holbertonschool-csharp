﻿using System;
using System.Collections.Generic;


class List
{
    // finds all multiples of 2 in a list.
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> isMultipleList = new List<bool>();
        // finds all multiples of 2 in a list.
        myList.ForEach(n => { Console.Write(n); isMultipleList.Add((n % 2 == 0) ? true : false); });
        // return it
        return isMultipleList;
    }
}
