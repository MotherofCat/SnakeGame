using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Snake Game - Adrianna Kaczor"; //overwrite console name
            Console.CursorVisible = false;

            Game snake = new Game(); //new snake game object
            snake.Run(); 
        }
    }
}