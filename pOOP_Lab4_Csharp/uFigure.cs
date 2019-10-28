using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace nsFigure
{
    class Figure
    {

        public Figure() // конструктор класса Figure
        {
        }

        public int timer { get; set; }
        public int elippseScale { get; set; } // коэффициент скорости фигуры
        public double direction { get; set; } // значение направления фигуры
        public int id { get; set; } // идентификатор положения базовой точки фигуры
        public Point[] point { get; set; } // массив точек траектории
        public Point basePoint { get; set; } // базовая точка фигуры
        public double breath { get; set; } // коэфициент скорости дыхания
        public double angle { get; set; } // скорость изменения угла фигуры

        //метод возвращает базовую точку фигуры
        public Point getPointFigure(Point[] point, int countPoint, int pos)
        {
            Point pEllipse = new Point(); // создает переменную типа Point

            if (timer == 0) // когда таймер на нуле сделать
                id = pos; // присвоить идентификатору положения точки, выбранное заранее положение

            if (id > countPoint - 1) // когда идентификатор превысил кол-во точек
                id = 0; // обнулить идентификатор

            if (id < 0) 
                id = countPoint - 1; // если меньше нуля то присвоить идентификатор последней точки

            pEllipse.X = point[id].X; // присвоить значение точки траектории точке фигуры
            pEllipse.Y = point[id].Y;
            // увеличить значение идентификатора с возможностью
            // замены направления движения фигуры
            // замены скорости движения фигуры
            id = id + (int)(direction * (elippseScale / 2)); 

            return pEllipse;
        }

        //Возвращает массив точек типа Point, который рисует треугольник
        Point[] getTriangle(int del, double angle)
        {
            Point p = new Point();// создает переменную типа Point
            Point[] pntFigure = new Point[3];// создает массив переменных типа Point

            // здесь происходит расчет радиуса в зависимости от треугольника, таймера и значения дыхания 
            double rad = 140 / del + (int)((70 / del * Math.Cos(timer * (Math.PI / (41 - (40 * breath))))));

            // расчет положения точек треугольников относительно базовой точки фигуры
            for (var k = 0; k < 3; k++)
            {
                p.X = basePoint.X + (int)((rad / 2) * Math.Cos((angle + Math.PI) + (k + 1) * ((2 * Math.PI) / 3)));
                p.Y = basePoint.Y - (int)((rad / 2) * Math.Sin((angle + Math.PI) + (k + 1) * ((2 * Math.PI) / 3)));
                pntFigure[k] = p;
            }

            return pntFigure;
        }

        // Рисует фигуру
        public void Draw(int countPoint, int pos, PaintEventArgs e)
        {
            basePoint = getPointFigure(point, countPoint, pos); // присвоение массива базовых точек фигуры

            double angl = (2 * Math.PI / (31-(30 * angle))) * timer; // здесь происходит расчет скорости поворота в зависимости от угла и таймера

            // Наприсовать главную фигуру
            e.Graphics.DrawPolygon(new Pen(Color.Black, 2), getTriangle(1, angl));
            e.Graphics.DrawPolygon(new Pen(Color.Black, 2), getTriangle(2, angl + Math.PI));
        }
    }
}

