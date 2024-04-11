using System;
using System.Collections.Generic;


class Dictionary
{
    //  returns the number of keys in a dictionary.
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        return myDict.Count;
    }

    // adds a key and value to a dictionary.
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        if (myDict.ContainsKey(key))
            myDict[key] = value;
        else
            myDict.Add(key, value);
        return myDict;
    }

    // deletes a key in a dictionary.
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        myDict.Remove(key);
        return myDict;
    }

    // returns a new dictionary with all values multiplied by 2.
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> multiplied = new Dictionary<string, int>(myDict.Count);
        foreach (KeyValuePair<string, int> item in myDict)
        {
            multiplied.Add(item.Key, item.Value * 2);
        }
        return multiplied;
    }
}
