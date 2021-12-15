using System;
using System.Collections.Generic;
using System.Drawing;

namespace Lab3_Invader
{
    class Stars
    {
        private List<Star> starField;
        Random random;
        Rectangle boundaries;

        public Stars(Rectangle boundaries, Random random)
        {
            this.boundaries = boundaries;
            this.random = random;
            starField = new List<Star>();
            AddStars(300);
        }

        public void Draw(Graphics g)
        {
            foreach (Star star in starField)
            {
                g.DrawEllipse(star.pen, star.point.X, star.point.Y, 1, 1);
            }
        }

        public void Twinkle()
        {
            RemoveStars(5);
            AddStars(5);
        }

        private void AddStars(int numberOfStarsToAdd)
        {
            for (int i = 0; i < numberOfStarsToAdd; i++)
            {
                Point randomPointWithinBoundaries = new Point(random.Next(boundaries.Right),
                    random.Next(boundaries.Bottom));
                Star newStar = new Star(randomPointWithinBoundaries, RandomColorPen(random));
                starField.Add(newStar);
            }
        }

        private void RemoveStars(int numberOfStarsToRemove)
        {
            for (int i = 0; i < numberOfStarsToRemove; i++)
            {
                int randomStarToRemoveIndex = random.Next(starField.Count);
                starField.Remove(starField[randomStarToRemoveIndex]);
            }
        }

        private Pen RandomColorPen(Random random)
        {
            Pen penToReturn = new Pen(Brushes.White);

            int colorSelectNumber = random.Next(5);

            switch (colorSelectNumber)
            {
                case 0:
                    penToReturn.Brush = Brushes.Blue;
                    break;
                case 1:
                    penToReturn.Brush = Brushes.PowderBlue;
                    break;
                case 2:
                    penToReturn.Brush = Brushes.SkyBlue;
                    break;
                case 3:
                    penToReturn.Brush = Brushes.RoyalBlue;
                    break;
                case 4:
                    penToReturn.Brush = Brushes.CornflowerBlue;
                    break;
                default: break;
            }
            return penToReturn;
        }
    }
}
