using System;
using System.Collections.Generic;


class Dictionary
{
    // returns the key with the biggest integer value in a given dictionary.
    public static string BestScore(Dictionary<string, int> myList)
    {
        KeyValuePair<string, int> pair = new KeyValuePair<string, int>("", -1);
        foreach (KeyValuePair<string, int> item in myList)
        {
            if (item.Value > pair.Value)
            {
                pair = item;
            }
        }
        return (pair.Value == -1) ? "None" : $"{pair.Key}";
    }

}