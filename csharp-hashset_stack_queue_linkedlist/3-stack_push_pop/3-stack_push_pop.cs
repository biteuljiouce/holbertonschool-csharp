using System;
using System.Collections.Generic;

class MyStack
{
    /*
    does the following:
    Print the number of items in aStack
        Format: Number of items: <number>
    Print the item at the top of aStack without removing it
        Format: Top item: <item>
        If aStack is empty, print Stack is empty
    Print if aStack contains a given item search
        Format: Stack contains <search>: <True / False>
    If aStack contains the given item search, remove all items up to and including search; otherwise, leave aStack as is
        You can use .P/o/p() only once
    Add a new given item newItem to aStack
    Return aStack
    */
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int count = aStack.Count;
        Console.WriteLine($"Number of items: {count}");
        if (count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine($"Top item: {aStack.Peek()}");
        bool containsSearch = aStack.Contains(search);
        if (containsSearch)
        {
            string item;
            do
            {
                item = aStack.Pop();
            }
            while (item != search);
        }
        Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");
        if (newItem != null)
            aStack.Push(newItem);
        return aStack;
    }
}
