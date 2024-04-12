using System;
using System.Collections.Generic;


class Dictionary
{
    // returns the key with the biggest integer value in a given dictionary.
    public static string BestScore(Dictionary<string, int> myList)
    {
        int max = -1;
        foreach (KeyValuePair<string, int> item in myList)
        {
            if (item.Value > max)
            {
                max = item.Value;
            }
        }
        return (max == -1) ? "None" : $"{max}";
    }

    // prints a dictionary by ordered keys.
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> sortedKeys = new List<string>();
        foreach (var item in myDict)
            sortedKeys.Add(item.Key);
        sortedKeys.Sort();
        sortedKeys.ForEach((string str) => Console.WriteLine(str));
    }
}