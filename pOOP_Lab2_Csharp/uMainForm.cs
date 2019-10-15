using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nsTrajectory;// Используем пространство имен (namespace) в котором находится траектория
using System.Diagnostics; // библиотека для диагностики программы

namespace pOOP_Lab_Csharp
{
   

    public partial class frmMain : Form
    {
        int i = 0;
        int k = 0;

        PointTrajectory objTrajectory = new PointTrajectory(); // Обьявление обьекта objTrajectory класса PointTrajectory

        
        public frmMain()
        {
            InitializeComponent();
            // Задать коэффициент угла поворота траектории расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.dubAngle = (double)tbTrajectoryAngle.Value / (double)(tbTrajectoryAngle.Maximum - tbTrajectoryAngle.Minimum);
            // Задать коэффициент положение траектории по вертикали расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.posY = (double)tbPositionY.Value / (double)(tbPositionY.Maximum - tbPositionY.Minimum);
            // Задать коэффициент положение траектории по горизонтали расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.posX = (double)tbPositionX.Value / (double)(tbPositionX.Maximum - tbPositionX.Minimum);
            // Задать коэффициент размера траектории расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.dubScale = (double)tbarTrajectorySize.Value / (double)(tbarTrajectorySize.Maximum - tbarTrajectorySize.Minimum);
            // Задать движения точки
            objTrajectory.elippseScale = tbarTrajectorySpeed.Value;
            // задать направление точки
            objTrajectory.direction = 1;
        }

        // функция, которая выполняется при рисовании pboxWorkSpace
        // Инструкция получения: В конструкторе нажать 1 раз на pboxWorkSpace, в "окне свойств" нажать на кнопку "молния"
        // Найти строку Paint, и нажать на нее два раза
        private void pboxWorkSpace_Paint(object sender, PaintEventArgs e)
        {
            // вызов функции рисования траектории
            // передает аргументы: обьект pmboxWorkSpace и обьект PaintEventArgs
            objTrajectory.Draw(pboxWorkSpace, e);
        }

        // функция, которая выполняется при изменении размера окна программы
        // Инструкция получения: В конструкторе нажать 1 раз на frmMain, в "окне свойств" нажать на кнопку "молния"
        // Найти строку Resize, и нажать на нее два раза
        private void frmMain_Resize(object sender, EventArgs e)
        {
            //Делает недействительной всю поверхность элемента управления и вызывает его перерисовку.
            Invalidate();
        }

        // функция, которая выполняется при изменении размера окна программы
        // Инструкция получения: В конструкторе нажать 1 раз на tbarTrajectorySize, в "окне свойств" нажать на кнопку "молния"
        // Найти строку ValueChanged, и нажать на нее два раза
        private void tbarTrajectorySize_ValueChanged(object sender, EventArgs e)
        {
            // Если значение ползунка равно 0, то поменять значение на 1
            if (tbarTrajectorySize.Value == 0) tbarTrajectorySize.Value = 1;
            // Задать коэффициент размера траектории по горизонтали расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.dubScale = (double)tbarTrajectorySize.Value / (double)(tbarTrajectorySize.Maximum - tbarTrajectorySize.Minimum);
            //Делает недействительной всю поверхность элемента управления и вызывает его перерисовку.
            Invalidate();
        }

        // функция, которая выполняется при рисовании frmMain
        // Инструкция получения: В конструкторе нажать 1 раз на frmMain, в "окне свойств" нажать на кнопку "молния"
        // Найти строку Paint, и нажать на нее два раза
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


        // функция, которая выполняется при тиканье таймера
        // Инструкция получения: В конструкторе нажать 1 раз на timer1, в "окне свойств" нажать на кнопку "молния"
        // Найти строку Tick, и нажать на нее два раза
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true; // включить таймер
            timer1.Interval = 40; // задать таймеру интервал между тиканием
            i++; // i=i+1;

            objTrajectory.timer = i; // передать обьекту траектории в переменную timer значение переменной i
            Invalidate();
        }

        // функция, которая выполняется при изменении ползунка
        // Инструкция получения: В конструкторе нажать 1 раз на tbarTrajectorySpeed, в "окне свойств" нажать на кнопку "молния"
        // Найти строку ValueChanged, и нажать на нее два раза
        private void tbarTrajectorySpeed_ValueChanged(object sender, EventArgs e) 
        {
            // Передать значение ползунка скорости точки на траектории переменной elippseScale обьекта Траектории
            objTrajectory.elippseScale = tbarTrajectorySpeed.Value;
            Invalidate();
        }

        // функция, которая выполняется при изменении состояния чекбокса
        // Инструкция получения: В конструкторе нажать 1 раз на checkBox1, в "окне свойств" нажать на кнопку "молния"
        // Найти строку ValueChanged, и нажать на нее два раза
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            k++; // k=k+1
            objTrajectory.direction = Math.Pow(-1, k); // передавать обьекту Траектории переменной direction значение -1 в степени k
            Invalidate();
        }

        // функция, которая выполняется при изменении ползунка
        // Инструкция получения: В конструкторе нажать 1 раз на tbTrajectoryAngle, в "окне свойств" нажать на кнопку "молния"
        // Найти строку ValueChanged, и нажать на нее два раза
        private void tbTrajectoryAngle_ValueChanged(object sender, EventArgs e)
        {
            // Передать коэффициент размера траектории расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))" переменной dubAngle обьекта Траектории
            objTrajectory.dubAngle = (double)tbTrajectoryAngle.Value / (double)(tbTrajectoryAngle.Maximum - tbTrajectoryAngle.Minimum);
            Invalidate();
        }

        // функция, которая выполняется при изменении ползунка
        // Инструкция получения: В конструкторе нажать 1 раз на tbPositionX, в "окне свойств" нажать на кнопку "молния"
        // Найти строку ValueChanged, и нажать на нее два раза
        private void tbPositionX_ValueChanged(object sender, EventArgs e)
        {
            // Передать коэффициент размера траектории расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))" переменной posX обьекта Траектории
            objTrajectory.posX = (double)tbPositionX.Value / (double)(tbPositionX.Maximum - tbPositionX.Minimum);
            Invalidate();
        }

        // функция, которая выполняется при изменении ползунка
        // Инструкция получения: В конструкторе нажать 1 раз на tbPositionY, в "окне свойств" нажать на кнопку "молния"
        // Найти строку ValueChanged, и нажать на нее два раза
        private void tbPositionY_ValueChanged(object sender, EventArgs e)
        {
            // Передать коэффициент размера траектории расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))" переменной posY обьекта Траектории
            objTrajectory.posY = (double)tbPositionY.Value / (double)(tbPositionY.Maximum - tbPositionY.Minimum);
            Invalidate();
        }
    }
}
