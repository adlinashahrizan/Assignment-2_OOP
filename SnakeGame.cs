using System;
using System.Collections.Generic;

//Task 2: Class Implementation
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

// Task 3: Object Creation & Interaction
class Program
{
    static void Main()
    {
        // Create objects
        Position pos = new Position(5, 5); 
        Snake snake = new Snake();
        Food food = new Food(pos, 10);

        // Initialise Head Position
        snake.BodySegments.Add(new Position(5, 5));

        // Call methods
        snake.Move();
        food.Spawn();

        // Interaction
       // Check if snake eats food
        if (food.CheckIfEaten(snake.GetHeadPosition()))
        {
            Console.WriteLine("Food eaten!");
            Console.WriteLine("Score: " + food.PointValue);
        }
        else
        {
            Console.WriteLine("Food not eaten.");
        }
    }
}
