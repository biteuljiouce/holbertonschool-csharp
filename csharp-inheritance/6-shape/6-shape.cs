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

/// <summary>
/// represents a rectangle.
/// </summary>
class Rectangle : Shape
{
    /*
    private field: private int width
    private field: private int height
    public property: public int Width
    get: retrieve width
    set: if value is negative, throw an ArgumentException with the message Width must be greater than or equal to 0. Otherwise, set width to the value.
    public property: public int Height
    get: retrieve height
    set: if value is negative, throw an ArgumentException with the message Height must be greater than or equal to 0. Otherwise, set Height to the value.
    */

    // width of rectangle
    private int width;
    // height of rectangle
    private int height;

    /// <summary>
    /// Width of rectangle 
    /// </summary>
    /// <value></value>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }
    /// <summary>
    /// Width of rectangle 
    /// </summary>
    /// <value></value>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }
}