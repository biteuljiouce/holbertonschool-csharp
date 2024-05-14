using System;

/// <summary>
/// Contains methods to test inheritance.
/// </summary>
class Obj
{

    /// <summary>
    /// returns True if the object is an instance of a class that inherits from the specified class, 
    /// otherwise return False. 
    /// The object must be a subclass; 
    /// your method cannot return True if the object is an instance of the base class.
    /// </summary>
    /// <param name="derivedType"></param>
    /// <param name="baseType"></param>
    /// <returns></returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        // we got 2 types to compare. IsAssignableFrom is the way.
        return baseType.IsAssignableFrom(derivedType) && derivedType != baseType;
    }
}
