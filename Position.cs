using System;
class Position
{
    // Private fields
    private int x;
    private int y;
    
    // Public properties 
    public int X
    {
        get { return x; }
        set { x = value; }
    }
    
    public int Y
    {
        get { return y; }
        set { y = value; }
    }
    
    // Constructor
    public Position(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    
    // Method
    public bool Equals(Position other)
    {
        return this.x == other.x && this.y == other.y;
    }
}