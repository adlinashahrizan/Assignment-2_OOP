using System;

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