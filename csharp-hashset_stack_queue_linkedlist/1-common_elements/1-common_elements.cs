using System;
using System.Collections.Generic;

class List
{
    //  returns a sorted list of common elements in two lists.
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> sortedCommons = new List<int>();
        foreach (int i in list1)
        {
            if (list2.Contains(i))
            {
                sortedCommons.Add(i);
            }
        }
        sortedCommons.Sort();
        return sortedCommons;
    }
}
