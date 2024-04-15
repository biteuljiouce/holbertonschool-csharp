using System;
using System.Collections.Generic;

class LList
{
    // inserts a new node in the correct position in an ordered LinkedList.
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = new LinkedListNode<int>(n);
        LinkedListNode<int> current = myLList.First;
        while (current != null && current.Value < n)
            current = current.Next;
        if (current == null)
            return node;
        else
            myLList.AddBefore(current, node);
        return node;
    }
}
