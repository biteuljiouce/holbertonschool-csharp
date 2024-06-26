﻿using System;
using System.Collections.Generic;


class Dictionary
{
    // prints a dictionary by ordered keys.
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> sortedKeys = new List<string>();
        foreach (var item in myDict)
            sortedKeys.Add(item.Key);
        sortedKeys.Sort();
        sortedKeys.ForEach((string str) => Console.WriteLine($"{str}: {myDict[str]}"));
    }
}