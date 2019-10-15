using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace nsFigure
{
    class Figure
    {

        public Figure()
        {
        }

        public double FiEllipse { get; set; }
        public int timer { get; set; }
        public int elippseScale { get; set; }
        public double direction { get; set; }
        public int id { get; set; }

        public Point getPointFigure(Point[] point, int countPoint, int pos)
        {
            Point pEllipse = new Point();

            if (timer == 0)
                id = pos;

            if (id > countPoint - 1)
                id = 0;

            if (id < 0)
                id = countPoint - 1;

            pEllipse.X = point[id].X;
            pEllipse.Y = point[id].Y;

            id = id + (int)direction * elippseScale;
            return pEllipse;
        }

        public void Draw(Point[] point, int countPoint, int pos, PaintEventArgs e)
        {
            Point basePoint;
            basePoint = getPointFigure(point, countPoint, pos);
            e.Graphics.DrawEllipse(new Pen(Color.Black, 2), (basePoint.X - 10), (basePoint.Y - 10), 20, 20);
        }
    }
}
