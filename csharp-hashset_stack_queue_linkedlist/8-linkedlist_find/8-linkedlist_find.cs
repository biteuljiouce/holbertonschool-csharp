using System;
using System.Collections.Generic;

class LList
{
    //  finds a value in a LinkedList and returns its index position in the list.
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;
        LinkedListNode<int> node = myLList.First;
        while (node != null)
        {
            if (node.Value == value)
            {
                return index;
            }
            index++;
            node = node.Next;
        }
        // value not found
        return -1;
    }
}
