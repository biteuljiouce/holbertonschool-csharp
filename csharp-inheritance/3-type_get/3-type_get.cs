using System;
using System.Reflection;

/// <summary>
/// Contains methods to test inheritance.
/// </summary>
class Obj
{
    /// <summary>
    /// prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">object to be analyzed.</param>
    /// <see href="https://learn.microsoft.com/en-us/dotnet/api/system.reflection.typeinfo"/>
    public static void Print(object myObj)
    {
        Type myObjType = myObj.GetType();
        TypeInfo info = myObjType.GetTypeInfo();
        Console.WriteLine($"{myObjType.Name} Properties:");
        foreach (PropertyInfo pi in info.GetProperties())
        {
            Console.WriteLine(pi.Name);
        }
        Console.WriteLine($"{myObjType.Name} Methods:");
        foreach (MethodInfo mi in info.GetMethods())
        {
            Console.WriteLine(mi.Name);
        }
    }
}
