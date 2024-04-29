using System;
using System.Collections.Generic;


class List
{
    // divides element by element 2 lists.
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int division;
        List<int> resultList = new List<int>(listLength);
        for (int i = 0; i < listLength; i++)
        {
            division = 0;
            try
            {
                division = list1[i] / list2[i];
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Out of range");
            }
            finally
            {
                resultList.Add(division);
            }
        }
        return resultList;
    }
}

