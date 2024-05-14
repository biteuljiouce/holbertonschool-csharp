using System;

/// <summary>
/// Contains methods to test inheritance.
/// </summary>
class Obj
{
    /// <summary>
    /// returns True if the object is an int, otherwise return False.
    /// </summary>
    /// <param name="obj">object to check if integer.</param>
    /// <returns>True if integer, False otherwise.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
