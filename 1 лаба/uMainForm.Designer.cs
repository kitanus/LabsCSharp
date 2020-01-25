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
            this.lblTrajectorySize = new System.Windows.Forms.Label();
            this.tbarTrajectorySize = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorkSpace)).BeginInit();
            this.pnlControlSpace.SuspendLayout();
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
            this.pnlControlSpace.Controls.Add(this.lblTrajectorySize);
            this.pnlControlSpace.Controls.Add(this.tbarTrajectorySize);
            this.pnlControlSpace.Location = new System.Drawing.Point(268, 13);
            this.pnlControlSpace.Name = "pnlControlSpace";
            this.pnlControlSpace.Size = new System.Drawing.Size(200, 298);
            this.pnlControlSpace.TabIndex = 1;
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
            this.tbarTrajectorySize.Location = new System.Drawing.Point(36, 53);
            this.tbarTrajectorySize.Name = "tbarTrajectorySize";
            this.tbarTrajectorySize.Size = new System.Drawing.Size(104, 45);
            this.tbarTrajectorySize.TabIndex = 0;
            this.tbarTrajectorySize.Value = 5;
            this.tbarTrajectorySize.ValueChanged += new System.EventHandler(this.tbarTrajectorySize_ValueChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.tbarTrajectorySize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxWorkSpace;
        private System.Windows.Forms.Panel pnlControlSpace;
        private System.Windows.Forms.TrackBar tbarTrajectorySize;
        private System.Windows.Forms.Label lblTrajectorySize;
    }
}

