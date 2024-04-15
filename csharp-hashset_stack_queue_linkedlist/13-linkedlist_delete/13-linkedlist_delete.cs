using System;
using System.Collections.Generic;

class LList
{
    //  deletes the node at given position in a LinkedList.
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index >= 0)
        {
            LinkedListNode<int> current = myLList.First;
            int i = 0;
            while (current != null && i < index)
            {
                i++;
                current = current.Next;
            }
            if (current != null)
                myLList.Remove(current);
        }
    }
}
