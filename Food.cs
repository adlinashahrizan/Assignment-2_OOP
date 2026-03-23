using System;

class Food
{
    // Private Fields
    private Position position;
    private int pointValue;
    private bool isEaten;

    // Public Properties
    public Position Position
    {
        get { return position; }
        set { position = value; }
    }

    public int PointValue
    {
        get { return pointValue; }
        set { pointValue = value; }
    }

    public bool IsEaten
    {
        get { return isEaten; }
        set { isEaten = value; }
    }

    // Constructor
    public Food(Position position, int value)
    {
        this.position = position;
        this.pointValue = value;
        this.isEaten = false;
    }

    // Methods
    public void Spawn()
    {
        Console.WriteLine("Food spawned");
    }
    public bool CheckIfEaten(Position snakeHead)
    {
        if (position.Equals(snakeHead))
        {
            isEaten = true;
            return true;
        }
        return false;
    }
}
