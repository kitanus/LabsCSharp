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
            this.lbValue = new System.Windows.Forms.Label();
            this.lbIndex = new System.Windows.Forms.Label();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbSetting = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
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
            this.pnlControlSpace.Controls.Add(this.btnPaste);
            this.pnlControlSpace.Controls.Add(this.btnCopy);
            this.pnlControlSpace.Controls.Add(this.lbValue);
            this.pnlControlSpace.Controls.Add(this.lbIndex);
            this.pnlControlSpace.Controls.Add(this.btnDeleteList);
            this.pnlControlSpace.Controls.Add(this.btnAddList);
            this.pnlControlSpace.Controls.Add(this.tbItem);
            this.pnlControlSpace.Controls.Add(this.btnAddItem);
            this.pnlControlSpace.Controls.Add(this.textBox1);
            this.pnlControlSpace.Controls.Add(this.lbSetting);
            this.pnlControlSpace.Controls.Add(this.button2);
            this.pnlControlSpace.Controls.Add(this.button1);
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
            this.pnlControlSpace.Size = new System.Drawing.Size(384, 343);
            this.pnlControlSpace.TabIndex = 1;
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(77, 242);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(54, 13);
            this.lbValue.TabIndex = 46;
            this.lbValue.Text = "значение";
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.Location = new System.Drawing.Point(23, 242);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(43, 13);
            this.lbIndex.TabIndex = 45;
            this.lbIndex.Text = "индекс";
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.Location = new System.Drawing.Point(26, 313);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteList.TabIndex = 44;
            this.btnDeleteList.Text = "Удалить";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(136, 284);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(75, 23);
            this.btnAddList.TabIndex = 43;
            this.btnAddList.Text = "Добавить";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // tbItem
            // 
            this.tbItem.Location = new System.Drawing.Point(58, 258);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(100, 20);
            this.tbItem.TabIndex = 42;
            this.tbItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbItem_KeyPress);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(26, 284);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(104, 23);
            this.btnAddItem.TabIndex = 41;
            this.btnAddItem.Text = "Изменить строку";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 40;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbSetting
            // 
            this.lbSetting.FormattingEnabled = true;
            this.lbSetting.Items.AddRange(new object[] {
            "140",
            "140"});
            this.lbSetting.Location = new System.Drawing.Point(245, 212);
            this.lbSetting.Name = "lbSetting";
            this.lbSetting.Size = new System.Drawing.Size(33, 95);
            this.lbSetting.TabIndex = 39;
            this.lbSetting.SelectedIndexChanged += new System.EventHandler(this.lbSetting_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Траектория";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Фон";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.lbSizeFigure.Size = new System.Drawing.Size(87, 13);
            this.lbSizeFigure.TabIndex = 27;
            this.lbSizeFigure.Text = "Размер фигуры";
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
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(254, 15);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 47;
            this.btnCopy.Text = "копировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(254, 45);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 48;
            this.btnPaste.Text = "вставить";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ListBox lbSetting;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.Label lbIndex;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
    }
}
