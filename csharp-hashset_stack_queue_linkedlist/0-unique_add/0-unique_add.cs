using System;
using System.Collections.Generic;

class List
{
    //  Returns the sum of unique integers in given list.
    public static int Sum(List<int> myList)
    {
        //myList.ForEach(item => Console.WriteLine(item));
        //Console.WriteLine();
        int sum = 0;
        if (myList.Count > 0)
        {
            sum = myList[0];
            List<int> noDouble = new List<int>();
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
        }
        return sum;
    }
}
