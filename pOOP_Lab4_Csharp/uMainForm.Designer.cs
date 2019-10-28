namespace pOOP_Lab_Csharp
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pboxWorkSpace = new System.Windows.Forms.PictureBox();
            this.pnlControlSpace = new System.Windows.Forms.Panel();
            this.lbTrajectoryAngle = new System.Windows.Forms.Label();
            this.lbTrajectoryPositionY = new System.Windows.Forms.Label();
            this.lbTrajectoryPositionX = new System.Windows.Forms.Label();
            this.tbPositionY = new System.Windows.Forms.TrackBar();
            this.tbPositionX = new System.Windows.Forms.TrackBar();
            this.tbTrajectoryAngle = new System.Windows.Forms.TrackBar();
            this.cbDirectionFigure = new System.Windows.Forms.CheckBox();
            this.lbAngleFigure = new System.Windows.Forms.Label();
            this.tbAngleFigure = new System.Windows.Forms.TrackBar();
            this.lbSizeFigure = new System.Windows.Forms.Label();
            this.lbSpeedFigure = new System.Windows.Forms.Label();
            this.tbSizeFigure = new System.Windows.Forms.TrackBar();
            this.tbSpeedFigure = new System.Windows.Forms.TrackBar();
            this.lblTrajectorySize = new System.Windows.Forms.Label();
            this.tbarTrajectorySize = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorkSpace)).BeginInit();
            this.pnlControlSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrajectoryAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAngleFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSizeFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeedFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarTrajectorySize)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxWorkSpace
            // 
            this.pboxWorkSpace.Location = new System.Drawing.Point(-1, 2);
            this.pboxWorkSpace.Name = "pboxWorkSpace";
            this.pboxWorkSpace.Size = new System.Drawing.Size(236, 321);
            this.pboxWorkSpace.TabIndex = 0;
            this.pboxWorkSpace.TabStop = false;
            this.pboxWorkSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxWorkSpace_Paint);
            // 
            // pnlControlSpace
            // 
            this.pnlControlSpace.Controls.Add(this.lbTrajectoryAngle);
            this.pnlControlSpace.Controls.Add(this.lbTrajectoryPositionY);
            this.pnlControlSpace.Controls.Add(this.lbTrajectoryPositionX);
            this.pnlControlSpace.Controls.Add(this.tbPositionY);
            this.pnlControlSpace.Controls.Add(this.tbPositionX);
            this.pnlControlSpace.Controls.Add(this.tbTrajectoryAngle);
            this.pnlControlSpace.Controls.Add(this.cbDirectionFigure);
            this.pnlControlSpace.Controls.Add(this.lbAngleFigure);
            this.pnlControlSpace.Controls.Add(this.tbAngleFigure);
            this.pnlControlSpace.Controls.Add(this.lbSizeFigure);
            this.pnlControlSpace.Controls.Add(this.lbSpeedFigure);
            this.pnlControlSpace.Controls.Add(this.tbSizeFigure);
            this.pnlControlSpace.Controls.Add(this.tbSpeedFigure);
            this.pnlControlSpace.Controls.Add(this.lblTrajectorySize);
            this.pnlControlSpace.Controls.Add(this.tbarTrajectorySize);
            this.pnlControlSpace.Location = new System.Drawing.Point(268, 13);
            this.pnlControlSpace.Name = "pnlControlSpace";
            this.pnlControlSpace.Size = new System.Drawing.Size(320, 330);
            this.pnlControlSpace.TabIndex = 1;
            // 
            // lbTrajectoryAngle
            // 
            this.lbTrajectoryAngle.AutoSize = true;
            this.lbTrajectoryAngle.Location = new System.Drawing.Point(5, 61);
            this.lbTrajectoryAngle.Name = "lbTrajectoryAngle";
            this.lbTrajectoryAngle.Size = new System.Drawing.Size(143, 13);
            this.lbTrajectoryAngle.TabIndex = 36;
            this.lbTrajectoryAngle.Text = "Угол поворота траектории";
            // 
            // lbTrajectoryPositionY
            // 
            this.lbTrajectoryPositionY.AutoSize = true;
            this.lbTrajectoryPositionY.Location = new System.Drawing.Point(7, 159);
            this.lbTrajectoryPositionY.Name = "lbTrajectoryPositionY";
            this.lbTrajectoryPositionY.Size = new System.Drawing.Size(151, 13);
            this.lbTrajectoryPositionY.TabIndex = 35;
            this.lbTrajectoryPositionY.Text = "Положение траектории по Y";
            // 
            // lbTrajectoryPositionX
            // 
            this.lbTrajectoryPositionX.AutoSize = true;
            this.lbTrajectoryPositionX.Location = new System.Drawing.Point(4, 111);
            this.lbTrajectoryPositionX.Name = "lbTrajectoryPositionX";
            this.lbTrajectoryPositionX.Size = new System.Drawing.Size(151, 13);
            this.lbTrajectoryPositionX.TabIndex = 34;
            this.lbTrajectoryPositionX.Text = "Положение траектории по Х";
            // 
            // tbPositionY
            // 
            this.tbPositionY.Location = new System.Drawing.Point(27, 175);
            this.tbPositionY.Name = "tbPositionY";
            this.tbPositionY.Size = new System.Drawing.Size(104, 45);
            this.tbPositionY.TabIndex = 33;
            this.tbPositionY.Value = 5;
            this.tbPositionY.ValueChanged += new System.EventHandler(this.tbPositionY_ValueChanged);
            // 
            // tbPositionX
            // 
            this.tbPositionX.Location = new System.Drawing.Point(19, 127);
            this.tbPositionX.Name = "tbPositionX";
            this.tbPositionX.Size = new System.Drawing.Size(104, 45);
            this.tbPositionX.TabIndex = 32;
            this.tbPositionX.Value = 5;
            this.tbPositionX.ValueChanged += new System.EventHandler(this.tbPositionX_ValueChanged);
            // 
            // tbTrajectoryAngle
            // 
            this.tbTrajectoryAngle.Location = new System.Drawing.Point(19, 79);
            this.tbTrajectoryAngle.Maximum = 30;
            this.tbTrajectoryAngle.Name = "tbTrajectoryAngle";
            this.tbTrajectoryAngle.Size = new System.Drawing.Size(104, 45);
            this.tbTrajectoryAngle.TabIndex = 31;
            this.tbTrajectoryAngle.ValueChanged += new System.EventHandler(this.tbTrajectoryAngle_ValueChanged);
            // 
            // cbDirectionFigure
            // 
            this.cbDirectionFigure.AutoSize = true;
            this.cbDirectionFigure.Location = new System.Drawing.Point(153, 15);
            this.cbDirectionFigure.Name = "cbDirectionFigure";
            this.cbDirectionFigure.Size = new System.Drawing.Size(94, 17);
            this.cbDirectionFigure.TabIndex = 30;
            this.cbDirectionFigure.Text = "Направление";
            this.cbDirectionFigure.UseVisualStyleBackColor = true;
            this.cbDirectionFigure.CheckedChanged += new System.EventHandler(this.cbDirectionFigure_CheckedChanged);
            // 
            // lbAngleFigure
            // 
            this.lbAngleFigure.AutoSize = true;
            this.lbAngleFigure.Location = new System.Drawing.Point(163, 142);
            this.lbAngleFigure.Name = "lbAngleFigure";
            this.lbAngleFigure.Size = new System.Drawing.Size(91, 13);
            this.lbAngleFigure.TabIndex = 29;
            this.lbAngleFigure.Text = "Поворот фигуры";
            // 
            // tbAngleFigure
            // 
            this.tbAngleFigure.Location = new System.Drawing.Point(154, 161);
            this.tbAngleFigure.Name = "tbAngleFigure";
            this.tbAngleFigure.Size = new System.Drawing.Size(104, 45);
            this.tbAngleFigure.TabIndex = 28;
            this.tbAngleFigure.Value = 1;
            this.tbAngleFigure.ValueChanged += new System.EventHandler(this.tbAngleFigure_ValueChanged);
            // 
            // lbSizeFigure
            // 
            this.lbSizeFigure.AutoSize = true;
            this.lbSizeFigure.Location = new System.Drawing.Point(160, 85);
            this.lbSizeFigure.Name = "lbSizeFigure";
            this.lbSizeFigure.Size = new System.Drawing.Size(142, 13);
            this.lbSizeFigure.TabIndex = 27;
            this.lbSizeFigure.Text = "Скорость дыхания фигуры";
            // 
            // lbSpeedFigure
            // 
            this.lbSpeedFigure.AutoSize = true;
            this.lbSpeedFigure.Location = new System.Drawing.Point(151, 37);
            this.lbSpeedFigure.Name = "lbSpeedFigure";
            this.lbSpeedFigure.Size = new System.Drawing.Size(96, 13);
            this.lbSpeedFigure.TabIndex = 26;
            this.lbSpeedFigure.Text = "Скорость фигуры";
            // 
            // tbSizeFigure
            // 
            this.tbSizeFigure.Location = new System.Drawing.Point(154, 104);
            this.tbSizeFigure.Maximum = 20;
            this.tbSizeFigure.Name = "tbSizeFigure";
            this.tbSizeFigure.Size = new System.Drawing.Size(104, 45);
            this.tbSizeFigure.TabIndex = 25;
            this.tbSizeFigure.Value = 5;
            this.tbSizeFigure.ValueChanged += new System.EventHandler(this.tbSizeFigure_ValueChanged);
            // 
            // tbSpeedFigure
            // 
            this.tbSpeedFigure.Location = new System.Drawing.Point(154, 53);
            this.tbSpeedFigure.Maximum = 5;
            this.tbSpeedFigure.Name = "tbSpeedFigure";
            this.tbSpeedFigure.Size = new System.Drawing.Size(104, 45);
            this.tbSpeedFigure.TabIndex = 24;
            this.tbSpeedFigure.Value = 2;
            this.tbSpeedFigure.ValueChanged += new System.EventHandler(this.tbSpeedFigure_ValueChanged);
            // 
            // lblTrajectorySize
            // 
            this.lblTrajectorySize.AutoSize = true;
            this.lblTrajectorySize.Location = new System.Drawing.Point(24, 13);
            this.lblTrajectorySize.Name = "lblTrajectorySize";
            this.lblTrajectorySize.Size = new System.Drawing.Size(107, 13);
            this.lblTrajectorySize.TabIndex = 1;
            this.lblTrajectorySize.Text = "Размер траектории";
            // 
            // tbarTrajectorySize
            // 
            this.tbarTrajectorySize.Location = new System.Drawing.Point(36, 29);
            this.tbarTrajectorySize.Name = "tbarTrajectorySize";
            this.tbarTrajectorySize.Size = new System.Drawing.Size(104, 45);
            this.tbarTrajectorySize.TabIndex = 0;
            this.tbarTrajectorySize.Value = 5;
            this.tbarTrajectorySize.ValueChanged += new System.EventHandler(this.tbarTrajectorySize_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 368);
            this.Controls.Add(this.pnlControlSpace);
            this.Controls.Add(this.pboxWorkSpace);
            this.Name = "frmMain";
            this.Text = "ООП Лабораторный цикл";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorkSpace)).EndInit();
            this.pnlControlSpace.ResumeLayout(false);
            this.pnlControlSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrajectoryAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAngleFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSizeFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeedFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarTrajectorySize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxWorkSpace;
        private System.Windows.Forms.Panel pnlControlSpace;
        private System.Windows.Forms.TrackBar tbarTrajectorySize;
        private System.Windows.Forms.Label lblTrajectorySize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTrajectoryAngle;
        private System.Windows.Forms.Label lbTrajectoryPositionY;
        private System.Windows.Forms.Label lbTrajectoryPositionX;
        private System.Windows.Forms.TrackBar tbPositionY;
        private System.Windows.Forms.TrackBar tbPositionX;
        private System.Windows.Forms.TrackBar tbTrajectoryAngle;
        private System.Windows.Forms.CheckBox cbDirectionFigure;
        private System.Windows.Forms.Label lbAngleFigure;
        private System.Windows.Forms.TrackBar tbAngleFigure;
        private System.Windows.Forms.Label lbSizeFigure;
        private System.Windows.Forms.Label lbSpeedFigure;
        private System.Windows.Forms.TrackBar tbSizeFigure;
        private System.Windows.Forms.TrackBar tbSpeedFigure;
    }
}

