using System; 
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics; // библиотека для диагностики программы

namespace nsTrajectory
{

    public class Trajectory
    {
        public Trajectory()
        {
        }
        // От -2 147 483 648 до 2 147 483 647 (int)
        // от ±5,0 × 10−324 до ±1,7 × 10308 (double)
        public Point pntBase { get; set; } // базовая точка класса Point (содержит свойства X и Y)
        public double dubScale { get; set; } // коэффициент размера траектории
        public int intVerticalSize { get; set; } // вертикальный размер эллипса
        public int intHorizontalSize { get; set; } // горизонтальный размер эллипса
        public double dubAngle { get; set; } // коэффициент угла поворота траектории
        public double posX { get; set; } // Позиция базовой точки по горизонтали
        public double posY { get; set; } // Позиция базовой точки по вертикали
        public int intPointCount { get; set; } // Колличество точек рисования

        //Аргументы: обьект pmboxWorkSpace и обьект PaintEventArgs
        public void Draw(PictureBox pboxWorkSpace, PaintEventArgs e)
        {
            Point p = new Point(); // Обьявление обьекта класса Point

            intVerticalSize = pboxWorkSpace.Height; // запись значение высоты области рисования в свойство класса uTrajectory
            intHorizontalSize = pboxWorkSpace.Width; // запись значение ширины области рисования в свойство класса uTrajectory

            pntBase = getBasePoint(p) ; // вызов метода, который возвращает значение базовой точки типа Point

            // Создание массива на 100 элементов типа Point
            intPointCount = 100; // колличество элементов в массиве
            Point[] pntFigure = new Point[intPointCount]; // Обьявление массива, значения которые типа обьекта класса Point

            double Fi = Math.PI / 2, // Начальное значение угла начала рисования
                deltaFi = Math.PI / (intPointCount / 2); // значение разницы приращения угла с каждой итерации
            
            intVerticalSize = (getSize(pntBase.Y, intVerticalSize)); // вызов метода, который возвращает измененный вертикальный размер эллипса
            intHorizontalSize = (getSize(pntBase.X, intHorizontalSize)/2);  // вызов метода, который возвращает измененный горизонтальный размер эллипса

            // Цикл который действует пока i < половины колва точек (i++ - значит, что после выполнения итерации цикла i=i+1)
            for (int i = 0; i < intPointCount/2; i++)
            {
                p.X = pntBase.X + (int)(intHorizontalSize * Math.Cos(Fi)); // вычисление точки x
                p.Y = pntBase.Y - (int)(intVerticalSize * Math.Sin(Fi)); // вычисление точки y
                pntFigure[i] = p; // запись переменной в массив в ячейку i
                Fi = Fi + deltaFi; // к углу прибавить приращение
            }

            Debug.WriteLine("H: " + intHorizontalSize + "; V: " + intVerticalSize); // функция которая выводит все что внутри скобок, в консоль "Вывод"

            pntFigure = getMove(pntFigure); // вызов метода, который возвращает массив измененных обьектов point (вращение фигуры)

            // разделение горизонтальной и вертикальной разницы между начальной и конечной точкой
            double deltaX = (double)(pntFigure[0].X - pntFigure[(intPointCount / 2) - 1].X) / (intPointCount / 2);
            double deltaY = (double)(pntFigure[0].Y - pntFigure[(intPointCount / 2) - 1].Y) / (intPointCount / 2);

            // рисование прямой соединяющей конечную точку и начальную точку
            for (int i = intPointCount / 2; i < intPointCount; i++)
            {
                p.X = pntFigure[(intPointCount / 2) - 1].X + (int)(deltaX * (i - (intPointCount / 2)));
                p.Y = pntFigure[(intPointCount / 2) - 1].Y + (int)(deltaY * (i - (intPointCount / 2)));
                pntFigure[i] = p;
            }
            
            e.Graphics.Clear(Color.White); // Очистка области рисование белым цветом

            // рисование замкнутой кривой, которая соединяет 
            //последовательно каждую точку по порядку и в конце соединяет последнюю и первую
            e.Graphics.DrawPolygon(new Pen(Color.Black, 4), pntFigure); 
        }

        // Возвращает ширину или высоту, чтобы не выходило за рамки
        public int getSize(int point, double size)
        {
            double div;

            if (point <= size - point) // если точка находится в левой части области рисования или ровно по центру
                div = (double)point / (size / 2);
            else // если в правой, то
                div = (double)(size - point) / (size / 2);

            return (int)(size / 2 * dubScale); // вернуть размер с коэффициентом размера траектории
        }

        // Возвращает базовую точку типа Point
        public Point getBasePoint(Point p) 
        {
            // Обозначение стартовой точки
            p.X = (int)(intHorizontalSize * (1 + (2 * posX)) / 4);
            p.Y = (int)(intVerticalSize * (1 + (2 * posY)) / 4);

            return p; // возвращение p
        }

        //Движение всех точек типа Point траектории по окружности относительно центра траектории
        public Point[] getMove(Point[] pntFigure)
        {
            double radius, sinY, cosX, resX, resY;

            for (int s = 0; s < intPointCount / 2; s++) //пока s<intPointCount / 2
            {
                // вычисление растояния от базовой точки до заданной точки
                radius = Math.Sqrt(Math.Pow((pntFigure[s].X - pntBase.X), 2) + Math.Pow((pntFigure[s].Y - pntBase.Y), 2));
                           
                // вычисление синуса угла для формулы окружности для заданной точки
                sinY = (pntFigure[s].Y - pntBase.Y) / radius;
                // вычисление косинуса угла для формулы окружности для заданной точки
                cosX = (pntFigure[s].X - pntBase.X) / radius;

                // вычисление косинуса суммы угла точки и угла поворота dubAngle
                resY = Math.Sin(2 * Math.PI * dubAngle) * cosX - Math.Cos(2 * Math.PI * dubAngle) * sinY;
                // вычисление синуса суммы угла точки и угла поворота dubAngle
                resX = cosX * Math.Cos(2 * Math.PI * dubAngle) + sinY * Math.Sin(2 * Math.PI * dubAngle);

                // положение точки после поворота
                pntFigure[s].X = pntBase.X + (int)(radius * resX);
                pntFigure[s].Y = pntBase.Y + (int)(radius * resY);

            }

            return pntFigure;
        }
    }
}
