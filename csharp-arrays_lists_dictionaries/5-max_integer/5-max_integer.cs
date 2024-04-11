using System;
using System.Collections.Generic;


class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else if (size == 0)
        {
            Console.WriteLine("");
            // Initializes a new instance of the List < T > class that is empty and has the default initial capacity.
            return new List<int>();
        }
        else
        {
            // Initializes a new instance of the List < T > class that is empty and has the default initial capacity.
            List<int> list = new List<int>(size);
            string msge = "";
            for (int i = 0; i < size; i++)
            {
                list.Add(i);
                msge += $"{list[i]} ";
            }
            // remove last space char
            Console.WriteLine(msge.Substring(0, msge.Length - 1));
            return list;
        }
    }

    // finds the biggest integer of a list.
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        else
        {
            int max = myList[0];
            foreach (int i in myList)
            {
                if (i > max)
                    max = i;
            }
            return max;
        }
    }
}
