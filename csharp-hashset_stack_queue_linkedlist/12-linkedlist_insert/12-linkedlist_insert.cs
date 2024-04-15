using System;
using System.Collections.Generic;

class LList
{
    // inserts a new node in the correct position in an ordered LinkedList.
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = new LinkedListNode<int>(n);
        LinkedListNode<int> current = myLList.First;
        while (current.Next != null && current.Value < n)
            current = current.Next;
        if (current.Value >= n)
            myLList.AddBefore(current, node);
        else
            myLList.AddAfter(current, node);

        return node;

    }
}