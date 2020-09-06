using System;
using SnakeGame.GameData;
using SnakeGame.GameObjects.Abstract;

namespace SnakeGame.GameObjects.Concrete
{
    public class Fruit : IFruit
    {
        private const int LowerFruitPositionLimit = (int) GameVariables.LowerFruitPositionLimit;
        private const int UpperFruitPositionLimit = (int) GameVariables.UpperFruitPositionLimit;
        public Position2D FruitPosition { get; }
        public Fruit()
        {
            Random rand = new Random();
            var x = rand.Next(LowerFruitPositionLimit, UpperFruitPositionLimit);
            var y = rand.Next(LowerFruitPositionLimit, UpperFruitPositionLimit);
            FruitPosition = new Position2D(x, y);
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(FruitPosition.X, FruitPosition.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("$");
        }
    }
}