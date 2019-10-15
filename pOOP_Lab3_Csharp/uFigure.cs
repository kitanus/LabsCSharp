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

        public int timer { get; set; } // свойство таймера
        public int elippseScale { get; set; } // свойство скорости фигуры
        public double direction { get; set; } // свойство направления движения фигуры
        public int id { get; set; } // свойство идентификатора точки из массива точек траектории
        public Point[] point { get; set; } // свойство значения базовой точки фигуры для ее определения
        public Point basePoint { get; set; } // свойство значения базовой точки фигуры для рисования фигуры
        public int radius { get; set; } // свойство размера фигуры
        public double angle { get; set; } // свойство угла поворота фигуры

        //Возвращает базовую точку фигуры в зависимости от позиции
        public Point getPointFigure(Point[] point, int countPoint, int pos)
        {
            Point pEllipse = new Point();

            if (timer == 0) // если первый тик, то
                id = pos;

            if (id > countPoint - 1) // если идентификатор больше колва ячеек массива то обнулить
                id = 0;

            if (id < 0) // если идентификатор меньше нуля то задать максимальный идентификатор массива
                id = countPoint - 1;

            pEllipse.X = point[id].X;
            pEllipse.Y = point[id].Y;
            id = id + (int)(direction * (elippseScale/2));
            return pEllipse;
        }

        //Возвращает массив точек типа Point, который рисует треугольник
        Point[] getTriangle(int radius, double angle)
        {
            Point p = new Point();
            Point[] pntFigure = new Point[3]; // для рисования треугольника надо только 3 точки

            // вычисление трех точек треугольника с помощью радиуса и угла
            for (var k = 0; k < 3; k++)
            {
                p.X = basePoint.X + (int)((radius / 2) * Math.Cos((angle + Math.PI) + (k + 1) * ((2 * Math.PI) / 3)));
                p.Y = basePoint.Y - (int)((radius / 2) * Math.Sin((angle + Math.PI) + (k + 1) * ((2 * Math.PI) / 3)));
                pntFigure[k] = p;
            }

            return pntFigure;
        }

        // Рисует фигуру
        public void Draw(int countPoint, int pos, PaintEventArgs e)
        {
            basePoint = getPointFigure(point, countPoint, pos); // занесение в переменную basePoint значения результата работы метода getPointFigure

            // рисование большого треугольника
            e.Graphics.DrawPolygon(new Pen(Color.Black, 2), getTriangle(radius, angle));

            // рисование маленького треугольника
            e.Graphics.DrawPolygon(new Pen(Color.Black, 2), getTriangle(radius / 2, angle + Math.PI));
        }
    }
}
