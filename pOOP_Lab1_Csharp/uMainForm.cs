using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nsTrajectory; // Используем пространство имен (namespace) в котором находится траектория

namespace pOOP_Lab_Csharp
{
   
    public partial class frmMain : Form
    {
        Trajectory objTrajectory = new Trajectory(); // Обьявление обьекта objTrajectory класса Trajectory

        public frmMain() // конструктор - функция которая работает сразу после создания обьекта класса frmMain
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
            //Делает недействительной всю поверхность элемента pboxWorkSpace управления и вызывает его перерисовку.
            pboxWorkSpace.Invalidate();
        }

        // функция, которая выполняется при изменении размера окна программы
        // Инструкция получения: В конструкторе нажать 1 раз на tbPositionX, в "окне свойств" нажать на кнопку "молния"
        // Найти строку ValueChanged, и нажать на нее два раза
        private void tbPositionX_ValueChanged(object sender, EventArgs e)
        {
            // Задать коэффициент расстояния центра  траектории по горизонтали расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.posX = (double)tbPositionX.Value / (double)(tbPositionX.Maximum - tbPositionX.Minimum);
            Invalidate();
        }

        // функция, которая выполняется при изменении размера окна программы
        // Инструкция получения: В конструкторе нажать 1 раз на tbPositionY, в "окне свойств" нажать на кнопку "молния"
        // Найти строку ValueChanged, и нажать на нее два раза
        private void tbPositionY_ValueChanged(object sender, EventArgs e)
        {
            // Задать коэффициент расстояния центра траектории по вертикали расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.posY = (double)tbPositionY.Value / (double)(tbPositionY.Maximum - tbPositionY.Minimum);
            Invalidate();
        }

        // функция, которая выполняется при изменении размера окна программы
        // Инструкция получения: В конструкторе нажать 1 раз на tbTrajectoryAngle, в "окне свойств" нажать на кнопку "молния"
        // Найти строку ValueChanged, и нажать на нее два раза
        private void tbTrajectoryAngle_ValueChanged(object sender, EventArgs e)
        {
            // Задать коэффициент размера траектории расчитанное по формуле "положение ползунка/((максимум ползунка-минимум ползунка))"
            objTrajectory.dubAngle = (double)tbTrajectoryAngle.Value / (double)(tbTrajectoryAngle.Maximum - tbTrajectoryAngle.Minimum);
            Invalidate();
        }
    }
}
