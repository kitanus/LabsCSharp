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
            this.pboxWorkSpace = new System.Windows.Forms.PictureBox();
            this.pnlControlSpace = new System.Windows.Forms.Panel();
            this.lbTrajectoryAngle = new System.Windows.Forms.Label();
            this.tbTrajectoryAngle = new System.Windows.Forms.TrackBar();
            this.lblTrajectorySize = new System.Windows.Forms.Label();
            this.tbarTrajectorySize = new System.Windows.Forms.TrackBar();
            this.tbPositionX = new System.Windows.Forms.TrackBar();
            this.tbPositionY = new System.Windows.Forms.TrackBar();
            this.lbTrajectoryPositionX = new System.Windows.Forms.Label();
            this.lbTrajectoryPositionY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorkSpace)).BeginInit();
            this.pnlControlSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrajectoryAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarTrajectorySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPositionY)).BeginInit();
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
            this.pnlControlSpace.Controls.Add(this.lblTrajectorySize);
            this.pnlControlSpace.Controls.Add(this.tbarTrajectorySize);
            this.pnlControlSpace.Location = new System.Drawing.Point(268, 13);
            this.pnlControlSpace.Name = "pnlControlSpace";
            this.pnlControlSpace.Size = new System.Drawing.Size(384, 298);
            this.pnlControlSpace.TabIndex = 1;
            // 
            // lbTrajectoryAngle
            // 
            this.lbTrajectoryAngle.AutoSize = true;
            this.lbTrajectoryAngle.Location = new System.Drawing.Point(14, 66);
            this.lbTrajectoryAngle.Name = "lbTrajectoryAngle";
            this.lbTrajectoryAngle.Size = new System.Drawing.Size(143, 13);
            this.lbTrajectoryAngle.TabIndex = 3;
            this.lbTrajectoryAngle.Text = "Угол поворота траектории";
            // 
            // tbTrajectoryAngle
            // 
            this.tbTrajectoryAngle.Location = new System.Drawing.Point(36, 82);
            this.tbTrajectoryAngle.Maximum = 30;
            this.tbTrajectoryAngle.Name = "tbTrajectoryAngle";
            this.tbTrajectoryAngle.Size = new System.Drawing.Size(104, 45);
            this.tbTrajectoryAngle.TabIndex = 2;
            this.tbTrajectoryAngle.ValueChanged += new System.EventHandler(this.tbTrajectoryAngle_ValueChanged);
            // 
            // lblTrajectorySize
            // 
            this.lblTrajectorySize.AutoSize = true;
            this.lblTrajectorySize.Location = new System.Drawing.Point(33, 15);
            this.lblTrajectorySize.Name = "lblTrajectorySize";
            this.lblTrajectorySize.Size = new System.Drawing.Size(107, 13);
            this.lblTrajectorySize.TabIndex = 1;
            this.lblTrajectorySize.Text = "Размер траектории";
            // 
            // tbarTrajectorySize
            // 
            this.tbarTrajectorySize.Location = new System.Drawing.Point(36, 31);
            this.tbarTrajectorySize.Name = "tbarTrajectorySize";
            this.tbarTrajectorySize.Size = new System.Drawing.Size(104, 45);
            this.tbarTrajectorySize.TabIndex = 0;
            this.tbarTrajectorySize.Value = 5;
            this.tbarTrajectorySize.ValueChanged += new System.EventHandler(this.tbarTrajectorySize_ValueChanged);
            // 
            // tbPositionX
            // 
            this.tbPositionX.Location = new System.Drawing.Point(36, 133);
            this.tbPositionX.Name = "tbPositionX";
            this.tbPositionX.Size = new System.Drawing.Size(104, 45);
            this.tbPositionX.TabIndex = 4;
            this.tbPositionX.Value = 5;
            this.tbPositionX.ValueChanged += new System.EventHandler(this.tbPositionX_ValueChanged);
            // 
            // tbPositionY
            // 
            this.tbPositionY.Location = new System.Drawing.Point(36, 184);
            this.tbPositionY.Name = "tbPositionY";
            this.tbPositionY.Size = new System.Drawing.Size(104, 45);
            this.tbPositionY.TabIndex = 5;
            this.tbPositionY.Value = 5;
            this.tbPositionY.ValueChanged += new System.EventHandler(this.tbPositionY_ValueChanged);
            // 
            // lbTrajectoryPositionX
            // 
            this.lbTrajectoryPositionX.AutoSize = true;
            this.lbTrajectoryPositionX.Location = new System.Drawing.Point(3, 114);
            this.lbTrajectoryPositionX.Name = "lbTrajectoryPositionX";
            this.lbTrajectoryPositionX.Size = new System.Drawing.Size(208, 13);
            this.lbTrajectoryPositionX.TabIndex = 6;
            this.lbTrajectoryPositionX.Text = "Положение траектории по горизонтали";
            // 
            // lbTrajectoryPositionY
            // 
            this.lbTrajectoryPositionY.AutoSize = true;
            this.lbTrajectoryPositionY.Location = new System.Drawing.Point(14, 165);
            this.lbTrajectoryPositionY.Name = "lbTrajectoryPositionY";
            this.lbTrajectoryPositionY.Size = new System.Drawing.Size(197, 13);
            this.lbTrajectoryPositionY.TabIndex = 7;
            this.lbTrajectoryPositionY.Text = "Положение траектории по вертикали";
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
            ((System.ComponentModel.ISupportInitialize)(this.tbTrajectoryAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarTrajectorySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPositionY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxWorkSpace;
        private System.Windows.Forms.Panel pnlControlSpace;
        private System.Windows.Forms.TrackBar tbarTrajectorySize;
        private System.Windows.Forms.Label lblTrajectorySize;
        private System.Windows.Forms.TrackBar tbTrajectoryAngle;
        private System.Windows.Forms.Label lbTrajectoryAngle;
        private System.Windows.Forms.TrackBar tbPositionX;
        private System.Windows.Forms.TrackBar tbPositionY;
        private System.Windows.Forms.Label lbTrajectoryPositionY;
        private System.Windows.Forms.Label lbTrajectoryPositionX;
    }
}

