using System;
using SnakeGame.GameObjects.Concrete;

namespace SnakeGame.GameControllers.Abstract
{
    public interface ISnakeController
    {
        public string ChangeDirection(ConsoleKeyInfo keyInfo);
        public bool ShowGameOverScreen(int score);
    }
}