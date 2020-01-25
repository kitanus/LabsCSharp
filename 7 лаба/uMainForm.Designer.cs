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
            this.btnSetAngles = new System.Windows.Forms.Button();
            this.btnDeleteColumn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AngleHexander = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnColorFigure = new System.Windows.Forms.Button();
            this.btnColorTrajectory = new System.Windows.Forms.Button();
            this.btnColorFon = new System.Windows.Forms.Button();
            this.tbChangeBreath = new System.Windows.Forms.TrackBar();
            this.lbChangeBreath = new System.Windows.Forms.Label();
            this.lblFPictureSpeed = new System.Windows.Forms.Label();
            this.tbarPictureSpeed = new System.Windows.Forms.TrackBar();
            this.lblTrajectorySize = new System.Windows.Forms.Label();
            this.tbarTrajectorySize = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cDFon = new System.Windows.Forms.ColorDialog();
            this.cDTrajectory = new System.Windows.Forms.ColorDialog();
            this.cDFigure = new System.Windows.Forms.ColorDialog();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWorkSpace)).BeginInit();
            this.pnlControlSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.pnlControlSpace.Controls.Add(this.btnPaste);
            this.pnlControlSpace.Controls.Add(this.btnCopy);
            this.pnlControlSpace.Controls.Add(this.btnSetAngles);
            this.pnlControlSpace.Controls.Add(this.btnDeleteColumn);
            this.pnlControlSpace.Controls.Add(this.dataGridView1);
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
            this.pnlControlSpace.Size = new System.Drawing.Size(325, 343);
            this.pnlControlSpace.TabIndex = 1;
            // 
            // btnSetAngles
            // 
            this.btnSetAngles.Location = new System.Drawing.Point(131, 220);
            this.btnSetAngles.Name = "btnSetAngles";
            this.btnSetAngles.Size = new System.Drawing.Size(146, 23);
            this.btnSetAngles.TabIndex = 11;
            this.btnSetAngles.Text = "Установить данные";
            this.btnSetAngles.UseVisualStyleBackColor = true;
            this.btnSetAngles.Click += new System.EventHandler(this.btnSetAngles_Click);
            // 
            // btnDeleteColumn
            // 
            this.btnDeleteColumn.Location = new System.Drawing.Point(131, 249);
            this.btnDeleteColumn.Name = "btnDeleteColumn";
            this.btnDeleteColumn.Size = new System.Drawing.Size(146, 23);
            this.btnDeleteColumn.TabIndex = 10;
            this.btnDeleteColumn.Text = "Удалить строку";
            this.btnDeleteColumn.UseVisualStyleBackColor = true;
            this.btnDeleteColumn.Click += new System.EventHandler(this.btnDeleteColumn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AngleHexander});
            this.dataGridView1.Location = new System.Drawing.Point(131, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(146, 198);
            this.dataGridView1.TabIndex = 9;
            // 
            // AngleHexander
            // 
            this.AngleHexander.HeaderText = "Угол";
            this.AngleHexander.Name = "AngleHexander";
            // 
            // btnColorFigure
            // 
            this.btnColorFigure.Location = new System.Drawing.Point(24, 245);
            this.btnColorFigure.Name = "btnColorFigure";
            this.btnColorFigure.Size = new System.Drawing.Size(75, 23);
            this.btnColorFigure.TabIndex = 8;
            this.btnColorFigure.Text = "Фигура";
            this.btnColorFigure.UseVisualStyleBackColor = true;
            this.btnColorFigure.Click += new System.EventHandler(this.btnColorFigure_Click);
            // 
            // btnColorTrajectory
            // 
            this.btnColorTrajectory.Location = new System.Drawing.Point(24, 220);
            this.btnColorTrajectory.Name = "btnColorTrajectory";
            this.btnColorTrajectory.Size = new System.Drawing.Size(75, 23);
            this.btnColorTrajectory.TabIndex = 7;
            this.btnColorTrajectory.Text = "Траектория";
            this.btnColorTrajectory.UseVisualStyleBackColor = true;
            this.btnColorTrajectory.Click += new System.EventHandler(this.btnColorTrajectory_Click);
            // 
            // btnColorFon
            // 
            this.btnColorFon.Location = new System.Drawing.Point(24, 191);
            this.btnColorFon.Name = "btnColorFon";
            this.btnColorFon.Size = new System.Drawing.Size(75, 23);
            this.btnColorFon.TabIndex = 6;
            this.btnColorFon.Text = "Фон";
            this.btnColorFon.UseVisualStyleBackColor = true;
            this.btnColorFon.Click += new System.EventHandler(this.btnColorFon_Click);
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
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(24, 284);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.Text = "Копировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(24, 313);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 13;
            this.btnPaste.Text = "Вставить";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AngleHexander;
        private System.Windows.Forms.Button btnDeleteColumn;
        private System.Windows.Forms.Button btnSetAngles;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
    }
}

