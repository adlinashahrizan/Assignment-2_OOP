using System;
using System.Collections.Generic;

class Snake
{
    // Private fields
    private List<Position> bodySegments;
    private string currentDirection;
    private int length;

    // Public properties 
    public List<Position> BodySegments
    {
        get { return bodySegments; }
        set { bodySegments = value; }
    }

    public string CurrentDirection
    {
        get { return currentDirection; }
        set { currentDirection = value; }
    }

    public int Length
    {
        get { return length; }
        set { length = value; }
    }

    // Constructor
    public Snake()
    {
        bodySegments = new List<Position>();
        length = 1;
        currentDirection = "RIGHT";
    }

    // Methods
    public void Move()
    {
        Console.WriteLine($"Snake is moving to the {currentDirection}");
    }

    public Position GetHeadPosition()
    {
        if (bodySegments.Count > 0)
            return bodySegments[0];
        else
            return null;
    }
}