using System;

/// <summary>
/// Contains methods to test inheritance.
/// </summary>
class Obj
{
    /// <summary>
    /// returns True if the object is an instance of, 
    /// or if the object is an instance of a class that inherited from Array,
    /// otherwise return False.
    /// </summary>
    /// <param name="obj">object to analyze.</param>
    /// <returns>see summary</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
