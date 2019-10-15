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
        public int color { get; set; }
        public int elippseScale { get; set; }
        public double direction { get; set; }
        public int id { get; set; }
        public Point[] point { get; set; }
        public Point basePoint { get; set; }
        public int[] angles { get; set; }
        public double radius { get; set; }
        public double angle { get; set; }

        //Возвращает базовую точку фигуры
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
            id = id + (int)(direction * (elippseScale / 2));

            return pEllipse;
        }

        //Возвращает массив точек типа Point, который рисует треугольник
        Point[] getTriangle(int del, double angle)
        {
            Point p = new Point();
            Point[] pntFigure = new Point[angles.Length];

            for (var k = 0; k < angles.Length; k++)
            {
                double rad = angles[k] / del + (int)((70 / del * Math.Cos(timer * (Math.PI / (41 - (40 * radius))))));
                p.X = basePoint.X + (int)((rad / 2) * Math.Cos((angle + Math.PI) + (k + 1) * ((2 * Math.PI) / angles.Length)));
                p.Y = basePoint.Y - (int)((rad / 2) * Math.Sin((angle + Math.PI) + (k + 1) * ((2 * Math.PI) / angles.Length)));
                pntFigure[k] = p;
            }

            return pntFigure;
        }

        // Рисует фигуру
        public void Draw(int countPoint, int pos, PaintEventArgs e)
        {
            basePoint = getPointFigure(point, countPoint, pos);

            double angl = (2 * Math.PI / (31-(30 * angle))) * timer;
            // Наприсовать главную фигуру
            e.Graphics.DrawPolygon(new Pen(getColor(), 2), getTriangle(1, angl));
            e.Graphics.DrawPolygon(new Pen(getColor(), 2), getTriangle(2, angl + Math.PI));
        }

        public Color getColor()
        {
            int red=255, green=0, blue=0;

            if(color<=255)
            {
                green = color;
            }

            if (color > 255 && color <= 510)
            {
                green = 255;
                red = 255 - (color - 255);
            }

            if (color > 510 && color <= 765)
            {
                green = 255;
                red = 0;
                blue =  (color - 510);
            }

            if (color > 765 && color <= 1020)
            {
                red = 0;
                blue = 255;
                green = 255-(color - 765);
            }

            if (color > 1020 && color <= 1275)
            {
                blue = 255;
                red = (color - 1020);
            }

            if (color > 1275 && color <= 1530)
            {
                blue = 255-(color - 1275);
            }

            return Color.FromArgb(red, green, blue);
        }
    }
}

