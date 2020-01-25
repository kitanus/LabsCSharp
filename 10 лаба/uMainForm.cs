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
        IniFile INI = new IniFile("config.ini");

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClipboardViewer(int hWndNewViewer);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern void SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        IntPtr nextClipboardViewer;

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

            nextClipboardViewer = (IntPtr)SetClipboardViewer((int)this.Handle);

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
            if (dataGridView1.RowCount > 8)
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    try
                    {
                        try
                        {

                            arrAngles[i] = Convert.ToInt32(dataGridView1[0, i].Value);
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            MessageBox.Show("Ошибка: Индекс находится вне массива: " + e.Message);
                        }
                    }
                    catch (FormatException e)
                    {
                        MessageBox.Show("Ошибка форматирования: " + e.Message);

                        dataGridView1[0, i].Value = 40;
                        arrAngles[i] = Convert.ToInt32(dataGridView1[0, i].Value);
                    }
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
            INI.Write("Figure", "Speed", Convert.ToString(tbarPictureSpeed.Value));
            INI.Write("Figure", "Size", Convert.ToString(tbChangeBreath.Value));

            INI.Write("Figure", "Figure", Convert.ToString(gridToString(dataGridView1)));

            ChangeClipboardChain(this.Handle, nextClipboardViewer);
        }

        private void inizializeIni()
        {
            if (INI.ReadINI("Trajectory", "Size").Length > 0)
                tbarTrajectorySize.Value = int.Parse(INI.ReadINI("Trajectory", "Size"));

            if (INI.ReadINI("Figure", "Speed").Length > 0)
                tbarPictureSpeed.Value = int.Parse(INI.ReadINI("Figure", "Speed"));

            if (INI.ReadINI("Figure", "Size").Length > 0)
                tbChangeBreath.Value = int.Parse(INI.ReadINI("Figure", "Size"));

            if (INI.ReadINI("Figure", "Figure").Length > 0)
                dataGridView1 = stringToGrid(INI.ReadINI("Figure", "Figure"), dataGridView1);

            setSides();
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            const int WM_DRAWCLIPBOARD = 0x308;
            const int WM_CHANGECBCHAIN = 0x030D;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    DisplayClipboardData("WM_DRAWCLIPBOARD");
                    SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;
                case WM_CHANGECBCHAIN:
                    rTBMessageView.Text = "Перехвачено сообщение: WM_CHANGECBCHAIN";
                    SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void DisplayClipboardData(string msg)
        {
            IDataObject iData = new DataObject();
            iData = Clipboard.GetDataObject();
            rTBMessageView.Text = "Перехвачено сообщение: " + msg + " Данные: " + (string)iData.GetData(DataFormats.Text);

            dataGridView1 = stringToGrid((string)iData.GetData(DataFormats.Text), dataGridView1);

            setSides();
        }
     }

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
