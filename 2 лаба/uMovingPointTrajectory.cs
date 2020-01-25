using System;
using System.Drawing;
using System.Windows.Forms;

using nsTrajectory;
namespace nsTrajectory
{
    enum enumSection { Curved, Straight }

    public class MovingPointTrajectory : Trajectory
    {
        public MovingPointTrajectory()
        {
        }

        private double incCorner = Math.PI;
        private enumSection Section;

        public Point pntCenterPos { get; set; }
        public double incSpeed = 0.01;

        public void NextBasePos()
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
            pntCenterPos = point;
        }

        public void drawPoint(PaintEventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.X = pntCenterPos.X - 10;
            rect.Y = pntCenterPos.Y - 10;
            rect.Height = 20;
            rect.Width = 20;
            e.Graphics.DrawEllipse(new Pen(Color.Black, 4), rect);
        }
    }
}

