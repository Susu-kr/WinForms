using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2_TheQuest
{
    abstract class Mover
    {
        private const int MOVE_INTERVAL = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            if ((Math.Abs(location.X - locationToCheck.X) < distance) &&
                (Math.Abs(location.Y - locationToCheck.Y) < distance))
                return true;
            return false;
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MOVE_INTERVAL >= boundaries.Top)
                        newLocation.Y -= MOVE_INTERVAL;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MOVE_INTERVAL <= boundaries.Bottom)
                        newLocation.Y += MOVE_INTERVAL;
                    break;
                case Direction.Left:
                    if (newLocation.X - MOVE_INTERVAL >= boundaries.Left)
                        newLocation.X -= MOVE_INTERVAL;
                    break;
                case Direction.Right:
                    if (newLocation.X + MOVE_INTERVAL <= boundaries.Right)
                        newLocation.X += MOVE_INTERVAL;
                    break;
            }
            return newLocation;
        }
    }
}
