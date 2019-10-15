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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbarTrajectorySpeed = new System.Windows.Forms.TrackBar();
            this.lblTrajectorySize = new System.Windows.Forms.Label();
            this.tbarTrajectorySize = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbSpeedPoint = new System.Windows.Forms.Label();
            this.lbTrajectoryPositionY = new System.Windows.Forms.Label();
            this.lbTrajectoryPositionX = new System.Windows.Forms.Label();
            this.tbPositionY = new System.Windows.Forms.TrackBar();
            this.tbPositionX = new System.Windows.Forms.TrackBar();
            this.lbTrajectoryAngle = new System.Windows.Forms.Label();
            this.tbTrajectoryAngle = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorkSpace)).BeginInit();
            this.pnlControlSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarTrajectorySpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarTrajectorySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrajectoryAngle)).BeginInit();
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
            this.pnlControlSpace.Controls.Add(this.lbTrajectoryPositionY);
            this.pnlControlSpace.Controls.Add(this.lbTrajectoryPositionX);
            this.pnlControlSpace.Controls.Add(this.tbPositionY);
            this.pnlControlSpace.Controls.Add(this.tbPositionX);
            this.pnlControlSpace.Controls.Add(this.lbTrajectoryAngle);
            this.pnlControlSpace.Controls.Add(this.tbTrajectoryAngle);
            this.pnlControlSpace.Controls.Add(this.lbSpeedPoint);
            this.pnlControlSpace.Controls.Add(this.checkBox1);
            this.pnlControlSpace.Controls.Add(this.tbarTrajectorySpeed);
            this.pnlControlSpace.Controls.Add(this.lblTrajectorySize);
            this.pnlControlSpace.Controls.Add(this.tbarTrajectorySize);
            this.pnlControlSpace.Location = new System.Drawing.Point(268, 13);
            this.pnlControlSpace.Name = "pnlControlSpace";
            this.pnlControlSpace.Size = new System.Drawing.Size(365, 298);
            this.pnlControlSpace.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(173, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Направление";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbarTrajectorySpeed
            // 
            this.tbarTrajectorySpeed.Location = new System.Drawing.Point(163, 31);
            this.tbarTrajectorySpeed.Maximum = 5;
            this.tbarTrajectorySpeed.Name = "tbarTrajectorySpeed";
            this.tbarTrajectorySpeed.Size = new System.Drawing.Size(104, 45);
            this.tbarTrajectorySpeed.TabIndex = 2;
            this.tbarTrajectorySpeed.ValueChanged += new System.EventHandler(this.tbarTrajectorySpeed_ValueChanged);
            // 
            // lblTrajectorySize
            // 
            this.lblTrajectorySize.AutoSize = true;
            this.lblTrajectorySize.Location = new System.Drawing.Point(24, 15);
            this.lblTrajectorySize.Name = "lblTrajectorySize";
            this.lblTrajectorySize.Size = new System.Drawing.Size(107, 13);
            this.lblTrajectorySize.TabIndex = 1;
            this.lblTrajectorySize.Text = "Размер траектории";
            // 
            // tbarTrajectorySize
            // 
            this.tbarTrajectorySize.Location = new System.Drawing.Point(27, 31);
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
            // lbSpeedPoint
            // 
            this.lbSpeedPoint.AutoSize = true;
            this.lbSpeedPoint.Location = new System.Drawing.Point(170, 15);
            this.lbSpeedPoint.Name = "lbSpeedPoint";
            this.lbSpeedPoint.Size = new System.Drawing.Size(86, 13);
            this.lbSpeedPoint.TabIndex = 4;
            this.lbSpeedPoint.Text = "Скорость точки";
            // 
            // lbTrajectoryPositionY
            // 
            this.lbTrajectoryPositionY.AutoSize = true;
            this.lbTrajectoryPositionY.Location = new System.Drawing.Point(15, 162);
            this.lbTrajectoryPositionY.Name = "lbTrajectoryPositionY";
            this.lbTrajectoryPositionY.Size = new System.Drawing.Size(197, 13);
            this.lbTrajectoryPositionY.TabIndex = 13;
            this.lbTrajectoryPositionY.Text = "Положение траектории по вертикали";
            // 
            // lbTrajectoryPositionX
            // 
            this.lbTrajectoryPositionX.AutoSize = true;
            this.lbTrajectoryPositionX.Location = new System.Drawing.Point(4, 111);
            this.lbTrajectoryPositionX.Name = "lbTrajectoryPositionX";
            this.lbTrajectoryPositionX.Size = new System.Drawing.Size(208, 13);
            this.lbTrajectoryPositionX.TabIndex = 12;
            this.lbTrajectoryPositionX.Text = "Положение траектории по горизонтали";
            // 
            // tbPositionY
            // 
            this.tbPositionY.Location = new System.Drawing.Point(37, 181);
            this.tbPositionY.Name = "tbPositionY";
            this.tbPositionY.Size = new System.Drawing.Size(104, 45);
            this.tbPositionY.TabIndex = 11;
            this.tbPositionY.Value = 5;
            this.tbPositionY.ValueChanged += new System.EventHandler(this.tbPositionY_ValueChanged);
            // 
            // tbPositionX
            // 
            this.tbPositionX.Location = new System.Drawing.Point(37, 130);
            this.tbPositionX.Name = "tbPositionX";
            this.tbPositionX.Size = new System.Drawing.Size(104, 45);
            this.tbPositionX.TabIndex = 10;
            this.tbPositionX.Value = 5;
            this.tbPositionX.ValueChanged += new System.EventHandler(this.tbPositionX_ValueChanged);
            // 
            // lbTrajectoryAngle
            // 
            this.lbTrajectoryAngle.AutoSize = true;
            this.lbTrajectoryAngle.Location = new System.Drawing.Point(4, 63);
            this.lbTrajectoryAngle.Name = "lbTrajectoryAngle";
            this.lbTrajectoryAngle.Size = new System.Drawing.Size(143, 13);
            this.lbTrajectoryAngle.TabIndex = 9;
            this.lbTrajectoryAngle.Text = "Угол поворота траектории";
            // 
            // tbTrajectoryAngle
            // 
            this.tbTrajectoryAngle.Location = new System.Drawing.Point(37, 79);
            this.tbTrajectoryAngle.Maximum = 30;
            this.tbTrajectoryAngle.Name = "tbTrajectoryAngle";
            this.tbTrajectoryAngle.Size = new System.Drawing.Size(104, 45);
            this.tbTrajectoryAngle.TabIndex = 8;
            this.tbTrajectoryAngle.ValueChanged += new System.EventHandler(this.tbTrajectoryAngle_ValueChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.tbarTrajectorySpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarTrajectorySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrajectoryAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxWorkSpace;
        private System.Windows.Forms.Panel pnlControlSpace;
        private System.Windows.Forms.TrackBar tbarTrajectorySize;
        private System.Windows.Forms.Label lblTrajectorySize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbarTrajectorySpeed;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbSpeedPoint;
        private System.Windows.Forms.Label lbTrajectoryPositionY;
        private System.Windows.Forms.Label lbTrajectoryPositionX;
        private System.Windows.Forms.TrackBar tbPositionY;
        private System.Windows.Forms.TrackBar tbPositionX;
        private System.Windows.Forms.Label lbTrajectoryAngle;
        private System.Windows.Forms.TrackBar tbTrajectoryAngle;
    }
}

