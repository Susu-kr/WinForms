using System.Drawing;
namespace Lab3_Invader
{
    class Shot
    {
        private const int moveInterval = 20;
        private const int width = 5;
        private const int height = 15;
        public Point Location { get; private set; }
        private Direction direction;
        private Rectangle boundaries;

        public Shot(Point location, Direction direction,
            Rectangle boundaries)
        {
            this.Location = location;
            this.direction = direction;
            this.boundaries = boundaries;
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Yellow, Location.X, Location.Y, width, height);
        }

        public bool Move(Direction directionToMove)
        {
            switch (directionToMove)
            {
                case Direction.Up:
                    Location = new Point(Location.X, Location.Y - moveInterval);
                    break;
                case Direction.Down:
                    Location = new Point(Location.X, Location.Y + moveInterval);
                    break;
                default:
                    break;
            }
            if ((Location.Y <= boundaries.Top) || (Location.Y >= boundaries.Bottom))
                return false;
            return true;
        }
    }
}
