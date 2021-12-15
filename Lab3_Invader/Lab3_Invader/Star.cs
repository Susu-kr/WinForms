using System.Drawing;

namespace Lab3_Invader
{
    struct Star
    {
        public Point point;
        public Pen pen;
        public Star(Point point, Pen pen)
        {
            this.point = point;
            this.pen = pen;
        }
    }
}
