using System;
using System.Collections.Generic;

class LList
{
    // adds a node to the beginning of a LinkedList.
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = new LinkedListNode<int>(n);
        myLList.AddFirst(node);
        return node;
    }
}
