using System.Drawing;

namespace Lab3_Invader
{
    class Invader
    {
        private const int HorizontalInterval = 10;
        private const int VerticalInterval = 40;
        private Bitmap image;
        private Size invaderSize = new Size(40, 40);
        public Point Location { get; private set; }
        public ShipType InvaderType { get; private set; }
        public Point BottomMiddle { get { return new Point((Area.Left + Area.Width / 2), Area.Bottom); } }

        public Rectangle Area
        {
            get { return new Rectangle(Location, image.Size); }
        }

        public int Score { get; private set; }

        public Invader(ShipType invaderType, Point location, int score)
        {
            this.InvaderType = invaderType;
            this.Location = location;
            this.Score = score;
            image = InvaderImage(0);
        }

        public void Move(Direction directionToMove)
        {
            switch (directionToMove)
            {
                case Direction.Left:
                    Location = new Point(Location.X - HorizontalInterval, Location.Y);
                    break;
                case Direction.Right:
                    Location = new Point(Location.X + HorizontalInterval, Location.Y);
                    break;
                case Direction.Down:
                    Location = new Point(Location.X, Location.Y + VerticalInterval);
                    break;
                default:
                    break;
            }
        }

        public void Draw(Graphics g, int animationCell)
        {
            image = InvaderImage(animationCell);
            g.DrawImageUnscaled(image, Location);
        } 

        private Bitmap InvaderImage(int animationCell)
        {
            Bitmap imageToReturn = new Bitmap(invaderSize.Width, invaderSize.Height);
            switch (animationCell)
            {
                case 0:
                    if (InvaderType == ShipType.Bug) imageToReturn = ResizeImage(Properties.Resources.bug1, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Saucer) imageToReturn = ResizeImage(Properties.Resources.flyingsaucer1, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Satellite) imageToReturn = ResizeImage(Properties.Resources.satellite1, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Spaceship) imageToReturn = ResizeImage(Properties.Resources.spaceship1, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Star) imageToReturn = ResizeImage(Properties.Resources.star1, invaderSize.Width, invaderSize.Height);
                    break;
                case 1:
                    if (InvaderType == ShipType.Bug) imageToReturn = ResizeImage(Properties.Resources.bug2, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Saucer) imageToReturn = ResizeImage(Properties.Resources.flyingsaucer2, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Satellite) imageToReturn = ResizeImage(Properties.Resources.satellite2, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Spaceship) imageToReturn = ResizeImage(Properties.Resources.spaceship2, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Star) imageToReturn = ResizeImage(Properties.Resources.star2, invaderSize.Width, invaderSize.Height);
                    break;
                case 2:
                    if (InvaderType == ShipType.Bug) imageToReturn = ResizeImage(Properties.Resources.bug3, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Saucer) imageToReturn = ResizeImage(Properties.Resources.flyingsaucer3, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Satellite) imageToReturn = ResizeImage(Properties.Resources.satellite3, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Spaceship) imageToReturn = ResizeImage(Properties.Resources.spaceship3, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Star) imageToReturn = ResizeImage(Properties.Resources.star3, invaderSize.Width, invaderSize.Height);
                    break;
                case 3:
                    if (InvaderType == ShipType.Bug) imageToReturn = ResizeImage(Properties.Resources.bug4, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Saucer) imageToReturn = ResizeImage(Properties.Resources.flyingsaucer4, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Satellite) imageToReturn = ResizeImage(Properties.Resources.satellite4, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Spaceship) imageToReturn = ResizeImage(Properties.Resources.spaceship4, invaderSize.Width, invaderSize.Height);
                    else if (InvaderType == ShipType.Star) imageToReturn = ResizeImage(Properties.Resources.star4, invaderSize.Width, invaderSize.Height);
                    break;
                default:
                    break;
            }
            return imageToReturn;
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
