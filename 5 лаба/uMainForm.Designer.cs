﻿namespace pOOP_Lab_Csharp
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
            this.tbChangeBreath = new System.Windows.Forms.TrackBar();
            this.lbChangeBreath = new System.Windows.Forms.Label();
            this.lblFPictureSpeed = new System.Windows.Forms.Label();
            this.tbarPictureSpeed = new System.Windows.Forms.TrackBar();
            this.lblTrajectorySize = new System.Windows.Forms.Label();
            this.tbarTrajectorySize = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cDFon = new System.Windows.Forms.ColorDialog();
            this.cDTrajectory = new System.Windows.Forms.ColorDialog();
            this.btnColorFon = new System.Windows.Forms.Button();
            this.btnColorTrajectory = new System.Windows.Forms.Button();
            this.btnColorFigure = new System.Windows.Forms.Button();
            this.cDFigure = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorkSpace)).BeginInit();
            this.pnlControlSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbChangeBreath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarPictureSpeed)).BeginInit();
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
            this.pnlControlSpace.Controls.Add(this.btnColorFigure);
            this.pnlControlSpace.Controls.Add(this.btnColorTrajectory);
            this.pnlControlSpace.Controls.Add(this.btnColorFon);
            this.pnlControlSpace.Controls.Add(this.tbChangeBreath);
            this.pnlControlSpace.Controls.Add(this.lbChangeBreath);
            this.pnlControlSpace.Controls.Add(this.lblFPictureSpeed);
            this.pnlControlSpace.Controls.Add(this.tbarPictureSpeed);
            this.pnlControlSpace.Controls.Add(this.lblTrajectorySize);
            this.pnlControlSpace.Controls.Add(this.tbarTrajectorySize);
            this.pnlControlSpace.Location = new System.Drawing.Point(268, 13);
            this.pnlControlSpace.Name = "pnlControlSpace";
            this.pnlControlSpace.Size = new System.Drawing.Size(325, 298);
            this.pnlControlSpace.TabIndex = 1;
            // 
            // tbChangeBreath
            // 
            this.tbChangeBreath.Location = new System.Drawing.Point(27, 151);
            this.tbChangeBreath.Name = "tbChangeBreath";
            this.tbChangeBreath.Size = new System.Drawing.Size(104, 45);
            this.tbChangeBreath.TabIndex = 5;
            this.tbChangeBreath.ValueChanged += new System.EventHandler(this.tbChangeBreath_ValueChanged);
            // 
            // lbChangeBreath
            // 
            this.lbChangeBreath.AutoSize = true;
            this.lbChangeBreath.Location = new System.Drawing.Point(24, 134);
            this.lbChangeBreath.Name = "lbChangeBreath";
            this.lbChangeBreath.Size = new System.Drawing.Size(101, 13);
            this.lbChangeBreath.TabIndex = 4;
            this.lbChangeBreath.Text = "Скорость дыхания";
            // 
            // lblFPictureSpeed
            // 
            this.lblFPictureSpeed.AutoSize = true;
            this.lblFPictureSpeed.Location = new System.Drawing.Point(21, 79);
            this.lblFPictureSpeed.Name = "lblFPictureSpeed";
            this.lblFPictureSpeed.Size = new System.Drawing.Size(86, 13);
            this.lblFPictureSpeed.TabIndex = 3;
            this.lblFPictureSpeed.Text = "Скорость точки";
            // 
            // tbarPictureSpeed
            // 
            this.tbarPictureSpeed.Location = new System.Drawing.Point(15, 95);
            this.tbarPictureSpeed.Name = "tbarPictureSpeed";
            this.tbarPictureSpeed.Size = new System.Drawing.Size(104, 45);
            this.tbarPictureSpeed.TabIndex = 2;
            this.tbarPictureSpeed.Value = 5;
            this.tbarPictureSpeed.ValueChanged += new System.EventHandler(this.tbarPictureSpeed_ValueChanged);
            // 
            // lblTrajectorySize
            // 
            this.lblTrajectorySize.AutoSize = true;
            this.lblTrajectorySize.Location = new System.Drawing.Point(12, 15);
            this.lblTrajectorySize.Name = "lblTrajectorySize";
            this.lblTrajectorySize.Size = new System.Drawing.Size(107, 13);
            this.lblTrajectorySize.TabIndex = 1;
            this.lblTrajectorySize.Text = "Размер траектории";
            // 
            // tbarTrajectorySize
            // 
            this.tbarTrajectorySize.Location = new System.Drawing.Point(15, 31);
            this.tbarTrajectorySize.Name = "tbarTrajectorySize";
            this.tbarTrajectorySize.Size = new System.Drawing.Size(104, 45);
            this.tbarTrajectorySize.TabIndex = 0;
            this.tbarTrajectorySize.Value = 5;
            this.tbarTrajectorySize.ValueChanged += new System.EventHandler(this.tbarTrajectorySize_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnColorFon
            // 
            this.btnColorFon.Location = new System.Drawing.Point(125, 15);
            this.btnColorFon.Name = "btnColorFon";
            this.btnColorFon.Size = new System.Drawing.Size(75, 23);
            this.btnColorFon.TabIndex = 6;
            this.btnColorFon.Text = "Фон";
            this.btnColorFon.UseVisualStyleBackColor = true;
            this.btnColorFon.Click += new System.EventHandler(this.btnColorFon_Click);
            // 
            // btnColorTrajectory
            // 
            this.btnColorTrajectory.Location = new System.Drawing.Point(125, 44);
            this.btnColorTrajectory.Name = "btnColorTrajectory";
            this.btnColorTrajectory.Size = new System.Drawing.Size(75, 23);
            this.btnColorTrajectory.TabIndex = 7;
            this.btnColorTrajectory.Text = "Траектория";
            this.btnColorTrajectory.UseVisualStyleBackColor = true;
            this.btnColorTrajectory.Click += new System.EventHandler(this.btnColorTrajectory_Click);
            // 
            // btnColorFigure
            // 
            this.btnColorFigure.Location = new System.Drawing.Point(125, 69);
            this.btnColorFigure.Name = "btnColorFigure";
            this.btnColorFigure.Size = new System.Drawing.Size(75, 23);
            this.btnColorFigure.TabIndex = 8;
            this.btnColorFigure.Text = "Фигура";
            this.btnColorFigure.UseVisualStyleBackColor = true;
            this.btnColorFigure.Click += new System.EventHandler(this.btnColorFigure_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.tbChangeBreath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarPictureSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarTrajectorySize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxWorkSpace;
        private System.Windows.Forms.Panel pnlControlSpace;
        private System.Windows.Forms.TrackBar tbarTrajectorySize;
        private System.Windows.Forms.Label lblTrajectorySize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFPictureSpeed;
        private System.Windows.Forms.TrackBar tbarPictureSpeed;
        private System.Windows.Forms.TrackBar tbChangeBreath;
        private System.Windows.Forms.Label lbChangeBreath;
        private System.Windows.Forms.Button btnColorFigure;
        private System.Windows.Forms.Button btnColorTrajectory;
        private System.Windows.Forms.Button btnColorFon;
        private System.Windows.Forms.ColorDialog cDFon;
        private System.Windows.Forms.ColorDialog cDTrajectory;
        private System.Windows.Forms.ColorDialog cDFigure;
    }
}

