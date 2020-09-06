using System;
using SnakeGame.GameControllers.Abstract;

namespace SnakeGame.GameControllers.Concrete
{
    public class SnakeController : ISnakeController
    {
        public string ChangeDirection(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    return "Left";
                case ConsoleKey.RightArrow:
                    return "Right";
                case ConsoleKey.UpArrow:
                    return "Up";
                case ConsoleKey.DownArrow:
                    return "Down";
            }

            return null;
        }

        public bool ShowGameOverScreen(int score)
        {
            Console.Clear();
            Console.WriteLine($"Game Over! Your snake was {score} segments long.");
            Console.WriteLine("Press any key to quit");
            Console.ReadLine();
            return true;
        }
    }
}