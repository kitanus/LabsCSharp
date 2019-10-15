using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nsTrajectory; // использование пространства имен в котором находится траектория
using nsFigure; // использование пространства имен в котором находится фигура
using System.Diagnostics; // использование класса который позволяет диагностировать

namespace pOOP_Lab_Csharp
{
   
    public partial class frmMain : Form
    {
        Trajectory objTrajectory = new Trajectory(); // обьявление обьекта траектории
        Figure objFigureOne = new Figure(); // обьявление обьекта первой фигуры
        Figure objFigureTwo = new Figure(); // обьявление обьекта второй фигуры

        public frmMain()
        {
            InitializeComponent(); // инициализация компонента
            // Передать свойству posY обьекта objTrajectory коэффициент положение траектории по вертикали расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.posY = (double)tbPositionY.Value / (double)(tbPositionY.Maximum - tbPositionY.Minimum);
            // Передать свойству posX обьекта objTrajectory коэффициент положение траектории по горизонтали расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.posX = (double)tbPositionX.Value / (double)(tbPositionX.Maximum - tbPositionX.Minimum);
            // Передать свойству dubScale обьекта objTrajectory коэффициент размера траектории расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.dubScale = (double)tbarTrajectorySize.Value / (double)(tbarTrajectorySize.Maximum - tbarTrajectorySize.Minimum);
            // Передать свойству dubAngle обьекта objTrajectory коэффициент угла поворота траектории расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.dubAngle = (double)tbTrajectoryAngle.Value / (double)(tbTrajectoryAngle.Maximum - tbTrajectoryAngle.Minimum);

            // Передать свойству elippseScale обьекта objFigureOne и objFigureTwo значение скорости фигуры
            objFigureOne.elippseScale = tbSpeedFigure.Value;
            objFigureTwo.elippseScale = tbSpeedFigure.Value;

            // Передать свойству radius обьекта objFigureOne и objFigureTwo значение размера фигуры
            objFigureOne.radius = tbSizeFigure.Value;
            objFigureTwo.radius = tbSizeFigure.Value;

            // Передать свойству angle обьекта objFigureOne и objFigureTwo угла фигуры
            objFigureOne.angle = (double)tbAngleFigure.Value / (double)(tbAngleFigure.Maximum - tbAngleFigure.Minimum);
            objFigureTwo.angle = (double)tbAngleFigure.Value / (double)(tbAngleFigure.Maximum - tbAngleFigure.Minimum);

            // Передать свойству direction обьекта objFigureOne и objFigureOne коэффициент угла поворота траектории расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objFigureOne.direction = 1;
            objFigureTwo.direction = 1;
        }

        private void pboxWorkSpace_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White); // Очистить поле белым цветом

            int countPoints = 100; // колличество точек в траектории (пока не понял как ее спрятать)

            objTrajectory.intPointCount = countPoints; // передача свойству intPointCount обьекта objTrajectory значение countPoints
            objTrajectory.Draw(pboxWorkSpace, e); // вызов метода Draw обьекта objTrajectory

            objFigureOne.point = objTrajectory.getTrajectoryPoints();

            // Рисование первой фигуры путем вызова метода Draw обьекта objFigureOne 
            // Аргументы: колличество точек траектории, идентификатор положения фигуры и обьект класса PaintEventArgs
            objFigureOne.Draw(countPoints, 0, e);

            objFigureTwo.point = objTrajectory.getTrajectoryPoints();
            objFigureTwo.Draw(countPoints, (int)(countPoints / 2), e);
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void tbarTrajectorySize_ValueChanged(object sender, EventArgs e)
        {
            // Если значение ползунка равно 0, то поменять значение на 1
            if (tbarTrajectorySize.Value == 0) tbarTrajectorySize.Value = 1;
            // Задать коэффициент размера траектории по горизонтали расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.dubScale = (double)tbarTrajectorySize.Value / (double)(tbarTrajectorySize.Maximum - tbarTrajectorySize.Minimum);
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            // настройки области рисования и контроля
            pboxWorkSpace.Top = 0; 
            pboxWorkSpace.Left = 0; 
            pboxWorkSpace.Height = this.ClientSize.Height;
            pboxWorkSpace.Width = this.ClientSize.Width / 2;
            pnlControlSpace.Top = 0; 
            pnlControlSpace.Left = this.ClientSize.Width / 2;
            pnlControlSpace.Height = this.ClientSize.Height;
            pnlControlSpace.Width = this.ClientSize.Width / 2;
            pboxWorkSpace.Invalidate();
        }

        int i = 0; // свойство для счетчика
        int k = 0; // свойство для направления движения

        // событие таймера тиканье
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true; // включение таймера
            timer1.Interval = 40; // интервал между тиканием
            i++;

            // передача свойству timer значение i
            objFigureOne.timer = i;
            objFigureTwo.timer = i;
            Invalidate();
        }

        // изменение скорости фигур
        private void tbSpeedFigure_ValueChanged(object sender, EventArgs e)
        {
            // передача свойству elippseScale обьекта objFigureOne значения позунка
            objFigureOne.elippseScale = tbSpeedFigure.Value;
            objFigureTwo.elippseScale = tbSpeedFigure.Value;
        }

        // изменение размера фигур
        private void tbSizeFigure_ValueChanged(object sender, EventArgs e)
        {
            // если 0, то задать значение 1
            if (tbSizeFigure.Value == 0) tbSizeFigure.Value = 1;
            // передача свойству radius обьекта objFigureOne значения позунка
            objFigureOne.radius = (double)(tbSizeFigure.Value) / (double)(tbSizeFigure.Maximum - tbSizeFigure.Minimum);
            objFigureTwo.radius = (double)(tbSizeFigure.Value) / (double)(tbSizeFigure.Maximum - tbSizeFigure.Minimum);
        }

        // изменение угла фигур
        private void tbAngleFigure_ValueChanged(object sender, EventArgs e)
        {
            // если 0, то задать значение 1
            if (tbAngleFigure.Value == 0) tbAngleFigure.Value = 1;

            // передача свойству angle обьекта objFigureOne значения угла с помощью ползунка
            objFigureOne.angle = (double)(tbAngleFigure.Value) / (double)(tbAngleFigure.Maximum - tbAngleFigure.Minimum);
            objFigureTwo.angle = (double)(tbAngleFigure.Value) / (double)(tbAngleFigure.Maximum - tbAngleFigure.Minimum);
        }

        // изменение угла траектории относительно ее центра
        private void tbTrajectoryAngle_ValueChanged(object sender, EventArgs e)
        {
            // передача свойству dubAngle обьекта objTrajectory значения по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.dubAngle = (double)tbTrajectoryAngle.Value / (double)(tbTrajectoryAngle.Maximum - tbTrajectoryAngle.Minimum);
        }

        // изменение положение базовой точки по горизонтали
        private void tbPositionX_ValueChanged(object sender, EventArgs e)
        {
            // передача свойству posX обьекта objTrajectory значения по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.posX = (double)tbPositionX.Value / (double)(tbPositionX.Maximum - tbPositionX.Minimum);
        }

        // изменение положение базовой точки по вертикали
        private void tbPositionY_ValueChanged(object sender, EventArgs e)
        {
            // передача свойству posY обьекта objTrajectory значения по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.posY = (double)tbPositionY.Value / (double)(tbPositionY.Maximum - tbPositionY.Minimum);
        }

        // изменение направление движения фигур при изменении состояния checkbox
        private void cbDirectionFigure_CheckedChanged(object sender, EventArgs e)
        {
            k++;

            // передача свойству direction обьекта objFigureOne значения -1 в степени k
            objFigureOne.direction = Math.Pow(-1, k);
            objFigureTwo.direction = Math.Pow(-1, k);
        }

    }
}
