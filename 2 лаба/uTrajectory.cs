using System;
using System.Drawing;
using System.Windows.Forms;

namespace nsTrajectory
{

    public class Trajectory
    {
        public Trajectory()
        {
        }

        public Point pntCenter { get; set; }
        public double dubScale { get; set; }
        public int radius { get; set; }
        public double intWidth { get; set; }
        public double intHeight { get; set; }

        public void DrawTrajectory(PictureBox pboxWorkSpace, PaintEventArgs e)
        {
            Point pnt = new Point();

            pnt.X = pboxWorkSpace.Width / 2;
            pnt.Y = pboxWorkSpace.Height / 2;

            pntCenter = pnt;

            intWidth = pboxWorkSpace.Width / 4;
            intHeight = pboxWorkSpace.Height / 2;

            int intPointCount = 100;
            Point[] pntTrajectory = new Point[intPointCount + 1];

            double Fi = Math.PI,
                incFi = Math.PI / intPointCount;

            for (int i = 0; i <= intPointCount; i++)
            {
                pnt.X = pntCenter.X + (int)(intWidth * Math.Cos(Fi) * dubScale);
                pnt.Y = pntCenter.Y - (int)(intHeight * Math.Sin(Fi) * dubScale);
                pntTrajectory[i] = pnt;
                Fi = Fi + incFi;
            }

            e.Graphics.Clear(Color.White);
            e.Graphics.DrawPolygon(new Pen(Color.Black, 4), pntTrajectory);
        }
    }
}
