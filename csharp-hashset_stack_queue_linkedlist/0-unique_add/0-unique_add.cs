using System;
using System.Collections.Generic;

class List
{
    //  Returns the sum of unique integers in given list.
    public static int Sum(List<int> myList)
    {
        //myList.ForEach(item => Console.WriteLine(item));
        //Console.WriteLine();
        List<int> noDouble = new List<int>();
        int sum = myList[0];
        noDouble.Add(myList[0]);
        foreach (int nb in myList)
        {
            if (!noDouble.Contains(nb))
            {
                noDouble.Add(nb);
                sum += nb;
            }
        }
        //noDouble.ForEach(item => Console.WriteLine(item));
        return sum;
    }
}
