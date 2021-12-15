using System;
using System.Drawing;

namespace Lab3_Invader
{
    class PlayerShip
    {
        private Bitmap image;
        private DateTime deadShipStartTime;
        private const int HorizontalInterval = 10;
        private int deadShipHeight;
        public Point Location { get; private set; }
        private bool alive;
        public bool Alive
        {
            get { return alive; }
            set
            {
                alive = value;
                deadShipStartTime = DateTime.Now;
            }
        }

        public Rectangle Area
        {
            get { return new Rectangle(Location, image.Size); }
        } 

        public Bitmap GetLivesLeftImage()
        {
            return ResizeImage(Properties.Resources.player, 40, 40);
        } 

        public Point TopMiddle
        {
            get
            {
                return new Point((Area.Left + Area.Width / 2), Area.Top);
            }
        } 

        public PlayerShip(Point location)
        {
            this.Location = location;
            image = ResizeImage(Properties.Resources.player, 40, 40);
            Alive = true;
            deadShipHeight = image.Height;
        }

        public void Draw(Graphics g)
        {
            if (!Alive)
            {
                Bitmap deadShipImage = new Bitmap(image);
                DateTime deadShipCurrentTime = DateTime.Now;
                TimeSpan duration = deadShipCurrentTime - deadShipStartTime;
                if (duration.Seconds < 3)
                {
                    if (deadShipHeight > 0) deadShipHeight -= 2;
                    g.DrawImage(deadShipImage, Location.X, Location.Y, Area.Width, deadShipHeight);
                }
                else
                {
                    Alive = true;
                    deadShipHeight = image.Height;
                    g.DrawImageUnscaled(image, Location);
                }
            }
            else
                g.DrawImageUnscaled(image, Location);
        }
        
        public void Move(Direction directionToMove)
        {
            Point moveTo;
            switch (directionToMove)
            {
                case Direction.Left:
                    moveTo = new Point(Location.X - HorizontalInterval, Location.Y);
                    Location = moveTo;
                    break;
                case Direction.Right:
                    moveTo = new Point(Location.X + HorizontalInterval, Location.Y);
                    Location = moveTo;
                    break;
                default:
                    break;
            }
        }

        private static Bitmap ResizeImage(Bitmap picture, int width, int height)
        {
            Bitmap resizedPicture = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedPicture))
            {
                graphics.DrawImage(picture, 0, 0, width, height);
            }
            return resizedPicture;
        }
    }
}
