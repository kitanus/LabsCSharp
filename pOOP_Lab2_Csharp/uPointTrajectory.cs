using System; 
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace nsTrajectory // то же пространство имен, в котором находится Trajectory
{
    // PointTrajectory - это дочерний класс родительского класса Trajectory
    // то есть все методы и свойства класса Trajectory доступен классу PointTrajectory
    // (кроме случая когда методы и свойства имеют модификатор доступа private)
    class PointTrajectory : Trajectory 
    {

        public PointTrajectory()
        {
        }

        public int idOne { get; set; } // идентификатор точки траектории
        public int idTwo { get; set; } // идентификатор точки траектории
        public Point[] point { get; set; } // базовая точка фигуры

        // метод рисования первой движимой точки
        public void DrawMovingPointOne(PaintEventArgs e)
        {
            if (timer == 0) // когда таймер на нуле установить идентификатор первого положени движимой точки
                idOne = (intPointCount/2);

            if (idOne > intPointCount - 1) // если идентификатор вышел за пределы массива, то обнулить его
                idOne = 0;

            if (idOne < 0) // если идентификатор вышел в отрицательную сторону пределы массива, то дать идентификатор последней ячейки массива
                idOne = intPointCount - 1;

            Point basePoint = pntFigure[idOne]; // получение точки траектории с данным идентификатором

            // Рисование эллипса аргументы(кисть, левый верхний угол прямоугольника по x, правый верхний угол прямоугольника по y, ширина прямоугольника, высота прямоугольника)
            e.Graphics.DrawEllipse(new Pen(Color.Black, 2), (basePoint.X - 10), (basePoint.Y - 10), 20, 20);

            idOne = idOne + (int)direction * elippseScale; // изменять идентификатор в зависимости от направления и скорости
        }

        // метод рисования движимой точки
        public void DrawMovingPointTwo(PaintEventArgs e)
        {
            if (timer == 0) // когда таймер на нуле установить идентификатор первого положени движимой точки
                idTwo = 0;

            if (idTwo > intPointCount - 1) // если идентификатор вышел за пределы массива, то обнулить его
                idTwo = 0;

            if (idTwo < 0) // если идентификатор вышел в отрицательную сторону пределы массива, то дать идентификатор последней ячейки массива
                idTwo = intPointCount - 1;

            Point basePoint = pntFigure[idTwo]; // получение точки траектории с данным идентификатором

            // Рисование эллипса аргументы(кисть, левый верхний угол прямоугольника по x, правый верхний угол прямоугольника по y, ширина прямоугольника, высота прямоугольника)
            e.Graphics.DrawEllipse(new Pen(Color.Black, 2), (basePoint.X - 10), (basePoint.Y - 10), 20, 20);

            idTwo = idTwo + (int)direction * elippseScale; // изменять идентификатор в зависимости от направления и скорости
        }

        // Рисование
        public void Draw(PictureBox pboxWorkSpace, PaintEventArgs e)
        {
            // вызов родительского метода рисования траектории
            DrawTrajectory(pboxWorkSpace, e);

            // вызов метода рисования первой движимой точки
            DrawMovingPointOne(e);

            // вызов метода рисования второй движимой точки
            DrawMovingPointTwo(e);

        }
    }
}
