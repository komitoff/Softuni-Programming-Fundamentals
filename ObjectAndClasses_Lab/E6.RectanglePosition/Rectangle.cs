using System;

public class Rectangle
{
    //read two rectangles {left, top, width, height} 
    public int Left { get; set; }
    public int Top { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public int Bottom
    {
        get
        {
            return Top + Height; 
        }
    }

    public int Right
    {
        get
        {
            return Left + Width;
        }
    }

    public bool IsInside (Rectangle r)
    {
        return (r.Left <= this.Left) &&
               (r.Right >= this.Right) &&
               (r.Bottom >= this.Bottom) &&
               (r.Top <= this.Top);
    }
}