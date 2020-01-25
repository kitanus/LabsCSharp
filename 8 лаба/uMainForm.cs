using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nsTrajectory;
using nsFigure;
using System.IO;
using System.Runtime.InteropServices;

namespace pOOP_Lab_Csharp
{
   
    public partial class frmMain : Form
    {
        Trajectory objTrajectory = new Trajectory();
        Figure objFigure = new Figure();
        
        Color backColor { set; get; }
        // обьявление обьекта класса IniFile, который в конструкторе берет имя файла
        IniFile INI = new IniFile("config.ini");

        public frmMain()
        {
            InitializeComponent();

            objTrajectory.dubScale = (double)tbarTrajectorySize.Value / (double)(tbarTrajectorySize.Maximum - tbarTrajectorySize.Minimum);
            objFigure.dubScale = (double)tbarTrajectorySize.Value / (double)(tbarTrajectorySize.Maximum - tbarTrajectorySize.Minimum);
            objFigure.incSpeed = (double)tbarPictureSpeed.Value / (double)(tbarPictureSpeed.Maximum - tbarPictureSpeed.Minimum);

            if (tbChangeBreath.Value == 10) tbChangeBreath.Value = 9;
            objFigure.breath = 1 - ((double)tbChangeBreath.Value / (double)(tbChangeBreath.Maximum - tbChangeBreath.Minimum));
            backColor = Color.White;
            objTrajectory.color = Color.Black;
            objFigure.color = Color.Black;
            objFigure.arrAngles = new int[] { 40, 40, 40, 40, 40, 40, 40, 40 };

            for (int i = 0; i < 8; i++)
                dataGridView1.Rows.Add("40");

            inizializeIni(); 
        }

        private void pboxWorkSpace_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(backColor), new Rectangle(0, 0, pboxWorkSpace.Height, pboxWorkSpace.Width));

            objTrajectory.DrawTrajectory(pboxWorkSpace, e);

            objFigure.pntCenter = objTrajectory.pntCenter;
            objFigure.radius = objTrajectory.radius;
            objFigure.intWidth = objTrajectory.intWidth;
            objFigure.intHeight = objTrajectory.intHeight;

            objFigure.drawFigure(e);
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void tbarTrajectorySize_ValueChanged(object sender, EventArgs e)
        {
            if (tbarTrajectorySize.Value == 0) tbarTrajectorySize.Value = 1;
            objTrajectory.dubScale = (double)tbarTrajectorySize.Value / (double)(tbarTrajectorySize.Maximum - tbarTrajectorySize.Minimum);
            objFigure.dubScale = (double)tbarTrajectorySize.Value / (double)(tbarTrajectorySize.Maximum - tbarTrajectorySize.Minimum);
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void tbarPictureSpeed_ValueChanged(object sender, EventArgs e)
        {
            objFigure.incSpeed = (double)tbarPictureSpeed.Value / (double)(tbarPictureSpeed.Maximum - tbarPictureSpeed.Minimum);
        }

        private void tbChangeBreath_ValueChanged(object sender, EventArgs e)
        {
            if (tbChangeBreath.Value == 10) tbChangeBreath.Value = 9;
            objFigure.breath = 1 - ((double)tbChangeBreath.Value / (double)(tbChangeBreath.Maximum - tbChangeBreath.Minimum));
        }

        private void btnColorFon_Click(object sender, EventArgs e)
        {
            if (cDFon.ShowDialog() == DialogResult.OK)
            {
                backColor = cDFon.Color;
            }
        }

        private void btnColorTrajectory_Click(object sender, EventArgs e)
        {
            if (cDTrajectory.ShowDialog() == DialogResult.OK)
            {
                objTrajectory.color = cDTrajectory.Color;
            }
        }

        private void btnColorFigure_Click(object sender, EventArgs e)
        {
            if (cDFigure.ShowDialog() == DialogResult.OK)
            {
                objFigure.color = cDFigure.Color;
            }
        }

        private void btnDeleteColumn_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;

            if (dataGridView1.Rows[indexRow].Cells[0].Value != null)
                dataGridView1.Rows.Remove(dataGridView1.Rows[indexRow]);
        }

        private void btnSetAngles_Click(object sender, EventArgs e)
        {
            setSides();
        }

        private void setSides()
        {
            int[] arrAngles = new int[dataGridView1.RowCount - 1];

            if (dataGridView1.RowCount - 1 >= 8)
			{
				for (int i = 0; i < dataGridView1.RowCount - 1; i++)
				{
					arrAngles[i] = Convert.ToInt32(dataGridView1[0, i].Value);
				}

				if (arrAngles.Length > 1)
				{
					objFigure.arrAngles = arrAngles;
				}
			}
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(gridToString(dataGridView1));
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            dataGridView1 = stringToGrid(Clipboard.GetText(), dataGridView1);

            setSides();
        }

        public string gridToString(DataGridView figure)
        {
            string figureInfo = "";

            for (int i = 0; i < figure.RowCount - 1; i++)
            {
                figureInfo = figureInfo + figure[0, i].Value;

                if (i < figure.RowCount - 2)
                {
                    figureInfo = figureInfo + "#";
                }
            }

            return figureInfo;
        }

        public DataGridView stringToGrid(string figureInfo, DataGridView figure)
        {
            if (figureInfo != null && figureInfo.Split('#') != null && figureInfo.Split('#').Length > 1)
            {
                string[] figureStringArray;

                figureStringArray = figureInfo.Split('#');

                figure.Rows.Clear();

                int number;

                for (int i = 0; i < figureStringArray.Length; i++)
                {
                    bool success = Int32.TryParse((string)figureStringArray[i], out number);

                    if (success)
                    {
                        figure.Rows.Add(figureStringArray[i]);
                    }
                }
            }

            return figure;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileStream stream = File.Open("config.ini", FileMode.Create);
            stream.Close();

            INI.Write("Trajectory", "Size", Convert.ToString(tbarTrajectorySize.Value));
            INI.Write("Trajectory", "Color", Convert.ToString(objTrajectory.color));
            INI.Write("Fon", "Color", Convert.ToString(backColor));
            INI.Write("Figure", "Speed", Convert.ToString(tbarPictureSpeed.Value));
            INI.Write("Figure", "Size", Convert.ToString(tbChangeBreath.Value));
            INI.Write("Figure", "Color", Convert.ToString(objFigure.color));

            INI.Write("Figure", "Figure", Convert.ToString(gridToString(dataGridView1)));
        }

        private Color getColorToString(string color)  
        {
            string[] arrNameColor = color.Split('['); // результат: ["Color ", "Black]"]
            arrNameColor = arrNameColor[1].Split(']'); // результат: ["Black",""]

            Color resultColor = new Color();

            if (arrNameColor[0].Contains('=')) // если внутри arrNameColor[0] есть подстрока "="
            {
                // если есть то перед нами Color [A=255, R=255, G=128, B=64]
                string[] arrColor = color.Split('='); // результат: ["Color [A","255, R","255, G","128, B","64]"];

                string[] alphaStr = arrColor[1].Split(','); // результат: ["255", " R"]
                int alpha = int.Parse(alphaStr[0]);

                string[] redString = arrColor[2].Split(',');// результат: ["255", " G"]
                int red = int.Parse(redString[0]);

                string[] greenString = arrColor[3].Split(',');// результат: ["128", " B"]
                int green = int.Parse(greenString[0]);

                string[] blueString = arrColor[4].Split(']');// результат: ["64", ""]
                int blue = int.Parse(blueString[0]);

                resultColor = Color.FromArgb(alpha, red, green, blue); // метод создает цвет из ARGB кода
            }
            else
            {
                // если подстроки "=" нет, то перед нами Color [Black] и мы уже вычленили Black
                resultColor = Color.FromName(arrNameColor[0]);// метод создает цвет из названия цвета
            }

            return resultColor;
        }

        private void inizializeIni()
        {
            // Чтение значение в секции такой то в переменной такой то
            // также проверка на наличие символов в этой переменной
            if (INI.ReadINI("Trajectory", "Size").Length > 0)
                tbarTrajectorySize.Value = int.Parse(INI.ReadINI("Trajectory", "Size"));

            if (INI.ReadINI("Trajectory", "Color").Length > 0) 
                objTrajectory.color = getColorToString(INI.ReadINI("Trajectory", "Color"));

            if (INI.ReadINI("Fon", "Color").Length > 0)
                backColor = getColorToString(INI.ReadINI("Fon", "Color"));

            if (INI.ReadINI("Figure", "Speed").Length > 0)
                tbarPictureSpeed.Value = int.Parse(INI.ReadINI("Figure", "Speed"));

            if (INI.ReadINI("Figure", "Size").Length > 0)
                tbChangeBreath.Value = int.Parse(INI.ReadINI("Figure", "Size"));

            if (INI.ReadINI("Figure", "Figure").Length > 0)
                dataGridView1 = stringToGrid(INI.ReadINI("Figure", "Figure"), dataGridView1);

            if (INI.ReadINI("Figure", "Color").Length > 0)
                objFigure.color = getColorToString(INI.ReadINI("Figure", "Color"));

            // установка данных фигуры
            setSides();
        }
     }

    // Это класс работы с ini-файлом (взят из инета полностью)
    // здесь импортируются методы из си и сформулирована логика работы с файлом до нас, про это советуется не упоминать
    class IniFile
    {
        string Path; //Имя файла.

        [DllImport("kernel32")] // Подключаем kernel32.dll и описываем его функцию WritePrivateProfilesString
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32")] // Еще раз подключаем kernel32.dll, а теперь описываем функцию GetPrivateProfileString
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        // С помощью конструктора записываем пусть до файла и его имя.
        public IniFile(string IniPath)
        {
            Path = new FileInfo(IniPath).FullName.ToString();
        }

        //Читаем ini-файл и возвращаем значение указного ключа из заданной секции.
        public string ReadINI(string Section, string Key)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        //Записываем в ini-файл. Запись происходит в выбранную секцию в выбранный ключ.
        public void Write(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, Path);
        }

        //Удаляем ключ из выбранной секции.
        public void DeleteKey(string Key, string Section = null)
        {
            Write(Section, Key, null);
        }

        //Удаляем выбранную секцию
        public void DeleteSection(string Section = null)
        {
            Write(Section, null, null);
        }

        //Проверяем, есть ли такой ключ, в этой секции
        public bool KeyExists(string Key, string Section = null)
        {
            return ReadINI(Section, Key).Length > 0;
        }
    }
}
