using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace nsFigure
{
    enum enumSection { Curved, Straight }

    public class Figure
    {
        public Figure()
        {
        }

        private double incCorner = Math.PI;
        private enumSection Section;

        public double incSpeed { get; set; }
        public Point pntCenter { get; set; }
        public int radius { get; set; }
        public double dubScale { get; set; }
        public double intWidth { get; set; }
        public double intHeight { get; set; }

        public Point NextBasePos()
        {
            incCorner += incSpeed * 0.1;

            if (incCorner > Math.PI)
            {
                incCorner = -Math.PI; Section = enumSection.Curved;
            }
            else if (incCorner > 0)
            {
                Section = enumSection.Straight;
            }

            Point point = new Point();
            point.X = pntCenter.X + (int)((double)intWidth * Math.Cos(incCorner) * dubScale);
            switch (Section)
            {
                case enumSection.Curved:
                    {
                        point.Y = pntCenter.Y - (int)((double)intHeight * Math.Sin(incCorner) * dubScale);
                        break;
                    }
                case enumSection.Straight:
                    {
                        point.Y = pntCenter.Y;
                        break;
                    }
            }
            
            return point;
        }

        public void getFigure(Point pntBase, PaintEventArgs e) 
        {
            Point pnt = new Point();
            Point[] pntFigure = new Point[4];

            int hyp = 40;

            double[] x = new double[] { -hyp / 2, -hyp, hyp / 2, hyp };
            double[] y = new double[] { hyp, hyp / 2, -hyp, -hyp / 2 };

            for (var k = 0; k < 4; k++)
            {
                pnt.X = pntBase.X + (int)(x[k]);
                pnt.Y = pntBase.Y + (int)(y[k]);
                pntFigure[k] = pnt;
            }

            e.Graphics.DrawPolygon(new Pen(Color.Black, 2), pntFigure);

            x = new double[] { hyp / 2, -hyp, -hyp / 2, hyp };
            y = new double[] { hyp, -hyp / 2, -hyp, hyp / 2 };

            for (var k = 0; k < 4; k++)
            {
                pnt.X = pntBase.X + (int)(x[k]);
                pnt.Y = pntBase.Y + (int)(y[k]);
                pntFigure[k] = pnt;
            }

            e.Graphics.DrawPolygon(new Pen(Color.Black, 2), pntFigure);
        }

        public void drawFigure(PaintEventArgs e) 
        {
            Point pntBasePos = NextBasePos();

            getFigure(pntBasePos, e);
        }
    }
}

