using System; 
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using nsFigure;

namespace nsTrajectory
{

    public class Trajectory
    {
        Figure objFigure = new Figure();
        Figure objFigureTwo = new Figure();

        public Trajectory()
        {
        }

        // От -2 147 483 648 до 2 147 483 647 (int)
        // от ±5,0 × 10−324 до ±1,7 × 10308 (double)
        public double dubScale { get; set; } // коэфициент увеличения размера главной фигуры
        public int intVerticalSize { get; set; } // средняя высота
        public int intHorizontalSize { get; set; } // средняя ширина
        public Point pntBase { get; set; }
        public double posX { get; set; }
        public double posY { get; set; }
        public double dubAngle { get; set; }
        public int intPointCount { get; set; }
        public Point[] figureTrajectory { get; set; } // массив обьектов типа Point с значениями каждой точки траектории

        public void Draw(PictureBox pboxWorkSpace, PaintEventArgs e)
        {
            Point p = new Point();

            intVerticalSize = pboxWorkSpace.Height;
            intHorizontalSize = pboxWorkSpace.Width;

            pntBase = getBasePoint(p);

            // Создание массива на 100 элементов типа Point
            intPointCount = 100;
            Point[] pntFigure = new Point[intPointCount];

            // Fi - начальный угол
            // deltaFi - сотая часть угла круга
            double Fi = Math.PI / 2,
                deltaFi = Math.PI / (intPointCount / 2);

            // Обозначение максимального радиуса
            intVerticalSize = getSize(pntBase.Y, intVerticalSize);
            intHorizontalSize = getSize(pntBase.X, intHorizontalSize) / 2;

            // Запись по порядку в массив все точки x и y
            for (int i = 0; i < intPointCount; i++)
            {
                p.X = pntBase.X + (int)(intHorizontalSize * Math.Cos(Fi));
                p.Y = pntBase.Y - (int)(intVerticalSize * Math.Sin(Fi));
                pntFigure[i] = p;
                Fi = Fi + deltaFi;
            }

            pntFigure = getMove(pntFigure);

            //Math.Sin((dubAngle * 2 * Math.PI))
            double deltaX = (double)(pntFigure[0].X - pntFigure[(intPointCount / 2) - 1].X) / (intPointCount / 2);
            double deltaY = (double)(pntFigure[0].Y - pntFigure[(intPointCount / 2) - 1].Y) / (intPointCount / 2);

            for (int i = intPointCount / 2; i < intPointCount; i++)
            {
                p.X = pntFigure[(intPointCount / 2) - 1].X + (int)(deltaX * (i - (intPointCount / 2)));
                p.Y = pntFigure[(intPointCount / 2) - 1].Y + (int)(deltaY * (i - (intPointCount / 2)));
                pntFigure[i] = p;
            }

            figureTrajectory = pntFigure; // запись полученного массива в свойство figureTrajectory класса trajectory

            // рисование замкнутой кривой, которая соединяет 
            //последовательно каждую точку по порядку и в конце соединяет последнюю и первую
            // в качестве третьего аргумента принимается значение метода getPointsTrajectory()
            e.Graphics.DrawPolygon(new Pen(Color.Black, 4), pntFigure);

        }

        // метод который возвращает значение свойства figureTrajectory (такие методы называются геттеры)
        public Point[] getTrajectoryPoints()
        {
            return figureTrajectory;
        }

        // Возвращает ширину или высоту
        public int getSize(int point, double size)
        {
            double div;

            if (point <= size - point)
                div = (double)point / (size / 2);
            else
                div = (double)(size - point) / (size / 2);

            return (int)(size / 2 * dubScale);
        }

        // Возвращает базовую точку типа Point
        public Point getBasePoint(Point p)
        {
            // Обозначение стартовой точки
            p.X = (intHorizontalSize / 4) + (int)((intHorizontalSize / 2) * posX);
            p.Y = (intVerticalSize / 4) + (int)((intVerticalSize / 2) * posY);

            return p;
        }

        //Движение всех точек типа Point траектории по окружности относительно центра траектории
        public Point[] getMove(Point[] pntFigure)
        {
            double radius, sinY, cosX, resX, resY;

            for (int s = 0; s < intPointCount / 2; s++) //5
            {
                radius = Math.Sqrt(Math.Pow((pntFigure[s].X - pntBase.X), 2) + Math.Pow((pntFigure[s].Y - pntBase.Y), 2));

                sinY = (pntFigure[s].Y - pntBase.Y) / radius;
                cosX = (pntFigure[s].X - pntBase.X) / radius;

                resY = Math.Sin(2 * Math.PI * dubAngle) * cosX - Math.Cos(2 * Math.PI * dubAngle) * sinY;
                resX = cosX * Math.Cos(2 * Math.PI * dubAngle) + sinY * Math.Sin(2 * Math.PI * dubAngle);

                pntFigure[s].X = pntBase.X + (int)(radius * resX);
                pntFigure[s].Y = pntBase.Y + (int)(radius * resY);
            }

            return pntFigure;
        }
    }
}
