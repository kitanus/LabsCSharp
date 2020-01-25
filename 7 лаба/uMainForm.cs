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

namespace pOOP_Lab_Csharp
{
   
    public partial class frmMain : Form
    {
        Trajectory objTrajectory = new Trajectory();
        Figure objFigure = new Figure();

        Color backColor { set; get; } 

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
            Invalidate();
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

            if(dataGridView1.RowCount - 1 >= 8)
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
     }
}
