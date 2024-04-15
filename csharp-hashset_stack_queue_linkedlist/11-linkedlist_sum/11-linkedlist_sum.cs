using System;
using System.Collections.Generic;

class LList
{
    // returns the sum of all the data of a LinkedList.
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;
        LinkedListNode<int> node = myLList.First;
        while (node != null)
        {
            sum += node.Value;
            node = node.Next;
        }
        return sum;
    }
}
