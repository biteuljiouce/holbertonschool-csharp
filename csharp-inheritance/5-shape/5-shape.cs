using System;

/// <summary>
/// represents a geometric shape.
/// </summary>
class Shape
{
    /// <summary>
    /// calculates area.
    /// </summary>
    /// <returns>area as integer</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
