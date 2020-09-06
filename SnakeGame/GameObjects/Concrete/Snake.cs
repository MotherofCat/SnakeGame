using System;
using System.Collections.Generic;
using System.Linq;
using SnakeGame.GameData;
using SnakeGame.GameObjects.Abstract;

namespace SnakeGame.GameObjects.Concrete
{
    public class Snake : ISnake
    {
        public string Direction  = "Right";
        public int Length { get; private set; } = (int) GameVariables.StartingSnakeLength;
        public Position2D HeadPosition { get; set; } = new Position2D();
        private List<Position2D> Tail { get; set; } = new List<Position2D>();
        private bool _outOfRange;

        public bool GameOver
        {
            get {
                return (Tail.Where(c => c.X == HeadPosition.X
                                        && c.Y == HeadPosition.Y).ToList().Count > 1) || _outOfRange;
            }
        }
        public void EatFruit()
        {
            Length++;
        }
        public void Move()
        {
            switch(Direction)
            {
                case "Left":
                    HeadPosition.X--;
                    break;
                case "Right":
                    HeadPosition.X++;
                    break;
                case "Up":
                    HeadPosition.Y--;
                    break;
                case "Down":
                    HeadPosition.Y++;
                    break;
            }
            try
            {
                Console.SetCursorPosition(HeadPosition.X, HeadPosition.Y);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("@");
                Tail.Add(new Position2D(HeadPosition.X, HeadPosition.Y));
                if (Tail.Count <= Length) return;
                var endTail = Tail.First();
                Console.SetCursorPosition(endTail.X, endTail.Y);
                Console.Write(" ");
                Tail.Remove(endTail);
            }
            catch(ArgumentOutOfRangeException)
            {
                _outOfRange = true;
            }
        }
    }
}