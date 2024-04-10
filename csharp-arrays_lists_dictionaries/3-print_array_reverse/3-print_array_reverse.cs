﻿using System;


class Array
{
    // creates and prints an array of integers of a given size.
    public static int[] CreatePrint(int size)
    {

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else if (size == 0)
        {
            Console.WriteLine();
            return new int[0];
        }
        else
        {
            int[] array = new int[size];
            char end = ' ';
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
                if (i == size - 1)
                    end = '\n';
                Console.Write($"{i}{end}");
            }
            return array;
        }

    }

    // retrieves an element from an array.
    public static int elementAt(int[] array, int index)
    {
        if (index >= 0 && index < array.Length)
            return array[index];
        else
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
    }

    // replaces an element of an array at a given index.
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index >= 0 && index < array.Length)
            array[index] = n;
        else
            Console.WriteLine("Index out of range");
        return array;
    }

    // prints all integers of an array, in reverse order.
    public static void Reverse(int[] array)
    {
        if (array != null)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                    Console.Write($"{array[i]}");
                else
                    Console.Write($"{array[i]} ");
            }
        }
        Console.WriteLine();
    }
}

