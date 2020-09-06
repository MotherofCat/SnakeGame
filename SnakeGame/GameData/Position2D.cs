namespace SnakeGame.GameData
{
    public class Position2D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Position2D()
        {
            X = 0;
            Y = 0;
        }
        public Position2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}