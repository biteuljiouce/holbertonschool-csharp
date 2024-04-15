using System;
using System.Collections.Generic;

class List
{
    // returns a sorted list of all elements present in one or the other list but not both.    
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> sortedDiffs = new List<int>();
        foreach (int i in list1)
        {
            if (!list2.Contains(i))
            {
                sortedDiffs.Add(i);
            }
        }
        foreach (int i in list2)
        {
            if (!list1.Contains(i))
            {
                sortedDiffs.Add(i);
            }
        }
        sortedDiffs.Sort();
        return sortedDiffs;
    }
}
