using System;
using System.Drawing;
using SnakeGame.GameControllers.Concrete;
using SnakeGame.GameData;
using SnakeGame.GameObjects.Concrete;

namespace SnakeGame
{
    public class Game
    {
        public void Run()
        {
            bool completedGame = false;
            double gameLoopInterval = (double) GameVariables.GameLoopInterval;
            DateTime lastDate = DateTime.Now; // Pobiera czas aktualny (z komputera) i zapisuje go jako akatualny
            
            Fruit fruit = new Fruit();
            Snake snake = new Snake();
            
            SnakeController snakeController = new SnakeController();
            
            while (!completedGame)
            {
                if (Console.KeyAvailable)
                {
                    string direction = snakeController.ChangeDirection(Console.ReadKey());
                    if (direction != null)
                    {
                        snake.Direction = direction;
                    }
                }
                
                if (!((DateTime.Now - lastDate).TotalMilliseconds >= gameLoopInterval)) continue;
                snake.Move();
                if (fruit.FruitPosition.X == snake.HeadPosition.X
                    && fruit.FruitPosition.Y == snake.HeadPosition.Y)
                {
                    snake.EatFruit();
                    fruit = new Fruit();
                    gameLoopInterval /= 1;
                }

                if (snake.GameOver)
                {
                    completedGame = snakeController.ShowGameOverScreen(snake.Length);
                }

                lastDate = DateTime.Now;
            }
        }
    }
}