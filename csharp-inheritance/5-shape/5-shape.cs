using System;

/// <summary>
/// represents a geometric shape.
/// </summary>
class Shape
{
    /// <summary>
    /// Calculates area.
    /// </summary>
    /// <returns>area</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area is not implemented.");
    }
}
