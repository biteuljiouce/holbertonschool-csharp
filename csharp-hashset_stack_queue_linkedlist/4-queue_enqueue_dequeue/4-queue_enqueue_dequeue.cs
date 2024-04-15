using System;
using System.Collections.Generic;

class MyQueue
{
    /*
    does the following:
    Print the number of items in aQueue
        Format: Number of items: <number>
    Print the item at the top of aQueue without removing it
        Format: First item: <item>
    If aQueue is empty, print Queue is empty
    Add a new given item newItem to aQueue
    Print if aQueue contains a given item search
        Format: Queue contains <search>: <True / False>
    If aQueue contains the given item search, remove all items up to and including search; otherwise, leave aQueue as is
        You can use .D/equeue() only once
    Return aQueue
    */
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int count = aQueue.Count;
        Console.WriteLine($"Number of items: {count}");
        if (count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine($"First item: {aQueue.Peek()}");
        bool containsSearch = aQueue.Contains(search);
        if (containsSearch)
        {
            string item;
            do
            {
                item = aQueue.Dequeue();
            }
            while (item != search);
        }
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");
        if (newItem != null)
            aQueue.Enqueue(newItem);
        return aQueue;
    }
}
