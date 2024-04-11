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
}
