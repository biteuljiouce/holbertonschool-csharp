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
            try
            {
                division = list1[i] / list2[i];
                resultList.Add(division);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero", ex.Message);
                division = 0;
                resultList.Add(division);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Out of range", ex.Message);
            }
        }
        return resultList;
    }
}

