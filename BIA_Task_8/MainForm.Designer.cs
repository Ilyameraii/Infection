namespace BIA_Task_8
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel = new System.Windows.Forms.Panel();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelInterval = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.numericUpDownInfection = new System.Windows.Forms.NumericUpDown();
            this.labelInfectiton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInfection)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(100, 74);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(300, 300);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(100, 48);
            this.numericUpDownSize.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numericUpDownSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownSize.TabIndex = 1;
            this.numericUpDownSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSize.ValueChanged += new System.EventHandler(this.numericUpDownSize_ValueChanged);
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownInterval.Location = new System.Drawing.Point(204, 48);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownInterval.TabIndex = 2;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownInterval.ValueChanged += new System.EventHandler(this.numericUpDownInterval_ValueChanged);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(85, 32);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(94, 13);
            this.labelSize.TabIndex = 3;
            this.labelSize.Text = "Размер матрицы";
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(185, 32);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(103, 13);
            this.labelInterval.TabIndex = 4;
            this.labelInterval.Text = "Интервал времени";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(104, 407);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(320, 407);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.Location = new System.Drawing.Point(221, 377);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(54, 20);
            this.labelTimer.TabIndex = 8;
            this.labelTimer.Text = "00:00";
            // 
            // numericUpDownInfection
            // 
            this.numericUpDownInfection.DecimalPlaces = 2;
            this.numericUpDownInfection.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownInfection.Location = new System.Drawing.Point(320, 48);
            this.numericUpDownInfection.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInfection.Name = "numericUpDownInfection";
            this.numericUpDownInfection.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownInfection.TabIndex = 9;
            this.numericUpDownInfection.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // labelInfectiton
            // 
            this.labelInfectiton.Location = new System.Drawing.Point(294, 20);
            this.labelInfectiton.Name = "labelInfectiton";
            this.labelInfectiton.Size = new System.Drawing.Size(126, 39);
            this.labelInfectiton.TabIndex = 10;
            this.labelInfectiton.Text = "Шанс заражения клетки с иммунитетом";
            this.labelInfectiton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.numericUpDownInfection);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.numericUpDownInterval);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.labelInfectiton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInfection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.NumericUpDown numericUpDownInfection;
        private System.Windows.Forms.Label labelInfectiton;
    }
}

