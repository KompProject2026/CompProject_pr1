namespace Prakt1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this.debounce = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._numAngle = new System.Windows.Forms.NumericUpDown();
            this._numV = new System.Windows.Forms.NumericUpDown();
            this._numR = new System.Windows.Forms.NumericUpDown();
            this._numY0 = new System.Windows.Forms.NumericUpDown();
            this._numX0 = new System.Windows.Forms.NumericUpDown();
            this._numH = new System.Windows.Forms.NumericUpDown();
            this._btnPlay = new System.Windows.Forms.Button();
            this._numW = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._canvas = new CompProject_Reflect.Canvas();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numY0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numW)).BeginInit();
            this.SuspendLayout();
            // 
            // _timer
            // 
            this._timer.Interval = 15;
            this._timer.Tick += new System.EventHandler(this._timer_Tick);
            // 
            // debounce
            // 
            this.debounce.Interval = 300;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2424, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 886);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1616, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(381, 856);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._numV);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this._btnStop);
            this.tabPage1.Controls.Add(this._numAngle);
            this.tabPage1.Controls.Add(this._numR);
            this.tabPage1.Controls.Add(this._numY0);
            this.tabPage1.Controls.Add(this._numX0);
            this.tabPage1.Controls.Add(this._numH);
            this.tabPage1.Controls.Add(this._btnPlay);
            this.tabPage1.Controls.Add(this._numW);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(373, 823);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Модель";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _numAngle
            // 
            this._numAngle.Location = new System.Drawing.Point(187, 334);
            this._numAngle.Maximum = new decimal(new int[] {
            89,
            0,
            0,
            0});
            this._numAngle.Minimum = new decimal(new int[] {
            89,
            0,
            0,
            -2147483648});
            this._numAngle.Name = "_numAngle";
            this._numAngle.Size = new System.Drawing.Size(120, 26);
            this._numAngle.TabIndex = 7;
            this._numAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // _numV
            // 
            this._numV.Location = new System.Drawing.Point(188, 302);
            this._numV.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this._numV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numV.Name = "_numV";
            this._numV.Size = new System.Drawing.Size(120, 26);
            this._numV.TabIndex = 6;
            this._numV.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // _numR
            // 
            this._numR.Location = new System.Drawing.Point(188, 270);
            this._numR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numR.Name = "_numR";
            this._numR.Size = new System.Drawing.Size(120, 26);
            this._numR.TabIndex = 5;
            this._numR.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // _numY0
            // 
            this._numY0.Location = new System.Drawing.Point(187, 238);
            this._numY0.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this._numY0.Name = "_numY0";
            this._numY0.Size = new System.Drawing.Size(120, 26);
            this._numY0.TabIndex = 4;
            this._numY0.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // _numX0
            // 
            this._numX0.Location = new System.Drawing.Point(188, 206);
            this._numX0.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this._numX0.Name = "_numX0";
            this._numX0.Size = new System.Drawing.Size(120, 26);
            this._numX0.TabIndex = 3;
            this._numX0.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // _numH
            // 
            this._numH.Location = new System.Drawing.Point(187, 174);
            this._numH.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this._numH.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._numH.Name = "_numH";
            this._numH.Size = new System.Drawing.Size(120, 26);
            this._numH.TabIndex = 2;
            this._numH.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // _btnPlay
            // 
            this._btnPlay.Location = new System.Drawing.Point(79, 450);
            this._btnPlay.Name = "_btnPlay";
            this._btnPlay.Size = new System.Drawing.Size(228, 47);
            this._btnPlay.TabIndex = 1;
            this._btnPlay.Text = "Старт";
            this._btnPlay.UseVisualStyleBackColor = true;
            this._btnPlay.Click += new System.EventHandler(this._btnPlay_Click);
            // 
            // _numW
            // 
            this._numW.Location = new System.Drawing.Point(187, 142);
            this._numW.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this._numW.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._numW.Name = "_numW";
            this._numW.Size = new System.Drawing.Size(120, 26);
            this._numW.TabIndex = 0;
            this._numW.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(373, 823);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вигляд";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _btnStop
            // 
            this._btnStop.Location = new System.Drawing.Point(80, 517);
            this._btnStop.Name = "_btnStop";
            this._btnStop.Size = new System.Drawing.Size(228, 47);
            this._btnStop.TabIndex = 8;
            this._btnStop.Text = "Рестарт";
            this._btnStop.UseVisualStyleBackColor = true;
            this._btnStop.Click += new System.EventHandler(this._btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Висота";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Х0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "У0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Радіус";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Швидкість";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "Кут";
            // 
            // _canvas
            // 
            this._canvas.BackColor = System.Drawing.Color.White;
            this._canvas.Location = new System.Drawing.Point(399, 23);
            this._canvas.Name = "_canvas";
            this._canvas.Size = new System.Drawing.Size(1217, 856);
            this._canvas.TabIndex = 2;
            this._canvas.Paint += new System.Windows.Forms.PaintEventHandler(this._canvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 908);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this._canvas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Відбиття кулі";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numY0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.Timer debounce;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private CompProject_Reflect.Canvas _canvas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown _numAngle;
        private System.Windows.Forms.NumericUpDown _numV;
        private System.Windows.Forms.NumericUpDown _numR;
        private System.Windows.Forms.NumericUpDown _numY0;
        private System.Windows.Forms.NumericUpDown _numX0;
        private System.Windows.Forms.NumericUpDown _numH;
        private System.Windows.Forms.Button _btnPlay;
        private System.Windows.Forms.NumericUpDown _numW;
        private System.Windows.Forms.Button _btnStop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

