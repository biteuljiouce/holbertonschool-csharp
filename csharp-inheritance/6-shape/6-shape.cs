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

/// <summary>
/// represents a rectangle.
/// </summary>
class Rectangle : Shape
{
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