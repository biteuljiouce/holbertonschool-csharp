using System;
using System.Collections.Generic;

class LList
{
    //  returns the value of the nth node of a LinkedList.
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int index = 0;
        LinkedListNode<int> node = myLList.First;
        while (node != null)
        {
            if (index == n)
            {
                return node.Value;
            }
            index++;
            node = node.Next;
        }
        if (node == null)
        {
            // didn't find the value
            return 0;
        }
        return index;
    }
}
