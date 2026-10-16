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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._btnSavePng = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this._trkSpeed = new System.Windows.Forms.TrackBar();
            this._btnStep = new System.Windows.Forms.Button();
            this._numV = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._btnStop = new System.Windows.Forms.Button();
            this._numAngle = new System.Windows.Forms.NumericUpDown();
            this._numR = new System.Windows.Forms.NumericUpDown();
            this._numY0 = new System.Windows.Forms.NumericUpDown();
            this._numX0 = new System.Windows.Forms.NumericUpDown();
            this._numH = new System.Windows.Forms.NumericUpDown();
            this._btnPlay = new System.Windows.Forms.Button();
            this._numW = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._chkInfo = new System.Windows.Forms.CheckBox();
            this._chkHits = new System.Windows.Forms.CheckBox();
            this._chkGrid = new System.Windows.Forms.CheckBox();
            this._chkVector = new System.Windows.Forms.CheckBox();
            this._chkTrail = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this._clbCmp = new System.Windows.Forms.CheckedListBox();
            this._btnClearCmp = new System.Windows.Forms.Button();
            this._btnAddCmp = new System.Windows.Forms.Button();
            this._numTmax = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this._canvas = new CompProject_Reflect.Canvas();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._trkSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numY0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numW)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numTmax)).BeginInit();
            this.SuspendLayout();
            // 
            // _timer
            // 
            this._timer.Interval = 15;
            this._timer.Tick += new System.EventHandler(this._timer_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1077, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 568);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1077, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(254, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._btnSavePng);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this._trkSpeed);
            this.tabPage1.Controls.Add(this._btnStep);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(246, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Модель";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _btnSavePng
            // 
            this._btnSavePng.Location = new System.Drawing.Point(52, 454);
            this._btnSavePng.Margin = new System.Windows.Forms.Padding(2);
            this._btnSavePng.Name = "_btnSavePng";
            this._btnSavePng.Size = new System.Drawing.Size(152, 31);
            this._btnSavePng.TabIndex = 19;
            this._btnSavePng.Text = "Зберегти png";
            this._btnSavePng.UseVisualStyleBackColor = true;
            this._btnSavePng.Click += new System.EventHandler(this._btnSavePng_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 390);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Швидкість відтворення";
            // 
            // _trkSpeed
            // 
            this._trkSpeed.Location = new System.Drawing.Point(52, 343);
            this._trkSpeed.Margin = new System.Windows.Forms.Padding(2);
            this._trkSpeed.Maximum = 20;
            this._trkSpeed.Minimum = 1;
            this._trkSpeed.Name = "_trkSpeed";
            this._trkSpeed.Size = new System.Drawing.Size(153, 45);
            this._trkSpeed.TabIndex = 17;
            this._trkSpeed.Tag = "";
            this._trkSpeed.Value = 10;
            this._trkSpeed.Scroll += new System.EventHandler(this._trkSpeed_Scroll);
            // 
            // _btnStep
            // 
            this._btnStep.Location = new System.Drawing.Point(52, 299);
            this._btnStep.Margin = new System.Windows.Forms.Padding(2);
            this._btnStep.Name = "_btnStep";
            this._btnStep.Size = new System.Drawing.Size(152, 31);
            this._btnStep.TabIndex = 16;
            this._btnStep.Text = "Крок";
            this._btnStep.UseVisualStyleBackColor = true;
            this._btnStep.Click += new System.EventHandler(this._btnStep_Click);
            // 
            // _numV
            // 
            this._numV.Location = new System.Drawing.Point(125, 142);
            this._numV.Margin = new System.Windows.Forms.Padding(2);
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
            this._numV.Size = new System.Drawing.Size(80, 20);
            this._numV.TabIndex = 6;
            this._numV.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Кут";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Швидкість";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Радіус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "У0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Х0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Висота";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ширина";
            // 
            // _btnStop
            // 
            this._btnStop.Location = new System.Drawing.Point(52, 253);
            this._btnStop.Margin = new System.Windows.Forms.Padding(2);
            this._btnStop.Name = "_btnStop";
            this._btnStop.Size = new System.Drawing.Size(152, 31);
            this._btnStop.TabIndex = 8;
            this._btnStop.Text = "Рестарт";
            this._btnStop.UseVisualStyleBackColor = true;
            this._btnStop.Click += new System.EventHandler(this._btnStop_Click);
            // 
            // _numAngle
            // 
            this._numAngle.Location = new System.Drawing.Point(125, 163);
            this._numAngle.Margin = new System.Windows.Forms.Padding(2);
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
            this._numAngle.Size = new System.Drawing.Size(80, 20);
            this._numAngle.TabIndex = 7;
            this._numAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // _numR
            // 
            this._numR.Location = new System.Drawing.Point(125, 122);
            this._numR.Margin = new System.Windows.Forms.Padding(2);
            this._numR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numR.Name = "_numR";
            this._numR.Size = new System.Drawing.Size(80, 20);
            this._numR.TabIndex = 5;
            this._numR.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // _numY0
            // 
            this._numY0.Location = new System.Drawing.Point(125, 101);
            this._numY0.Margin = new System.Windows.Forms.Padding(2);
            this._numY0.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this._numY0.Name = "_numY0";
            this._numY0.Size = new System.Drawing.Size(80, 20);
            this._numY0.TabIndex = 4;
            this._numY0.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // _numX0
            // 
            this._numX0.Location = new System.Drawing.Point(125, 80);
            this._numX0.Margin = new System.Windows.Forms.Padding(2);
            this._numX0.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this._numX0.Name = "_numX0";
            this._numX0.Size = new System.Drawing.Size(80, 20);
            this._numX0.TabIndex = 3;
            this._numX0.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // _numH
            // 
            this._numH.Location = new System.Drawing.Point(125, 59);
            this._numH.Margin = new System.Windows.Forms.Padding(2);
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
            this._numH.Size = new System.Drawing.Size(80, 20);
            this._numH.TabIndex = 2;
            this._numH.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // _btnPlay
            // 
            this._btnPlay.Location = new System.Drawing.Point(52, 209);
            this._btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this._btnPlay.Name = "_btnPlay";
            this._btnPlay.Size = new System.Drawing.Size(152, 31);
            this._btnPlay.TabIndex = 1;
            this._btnPlay.Text = "Старт";
            this._btnPlay.UseVisualStyleBackColor = true;
            this._btnPlay.Click += new System.EventHandler(this._btnPlay_Click);
            // 
            // _numW
            // 
            this._numW.Location = new System.Drawing.Point(125, 38);
            this._numW.Margin = new System.Windows.Forms.Padding(2);
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
            this._numW.Size = new System.Drawing.Size(80, 20);
            this._numW.TabIndex = 0;
            this._numW.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._chkInfo);
            this.tabPage2.Controls.Add(this._chkHits);
            this.tabPage2.Controls.Add(this._chkGrid);
            this.tabPage2.Controls.Add(this._chkVector);
            this.tabPage2.Controls.Add(this._chkTrail);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(246, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вигляд";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _chkInfo
            // 
            this._chkInfo.AutoSize = true;
            this._chkInfo.Checked = true;
            this._chkInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkInfo.Location = new System.Drawing.Point(65, 189);
            this._chkInfo.Margin = new System.Windows.Forms.Padding(2);
            this._chkInfo.Name = "_chkInfo";
            this._chkInfo.Size = new System.Drawing.Size(85, 17);
            this._chkInfo.TabIndex = 4;
            this._chkInfo.Text = "Інфопанель";
            this._chkInfo.UseVisualStyleBackColor = true;
            this._chkInfo.CheckedChanged += new System.EventHandler(this._chk_CheckedChanged);
            // 
            // _chkHits
            // 
            this._chkHits.AutoSize = true;
            this._chkHits.Checked = true;
            this._chkHits.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkHits.Location = new System.Drawing.Point(65, 155);
            this._chkHits.Margin = new System.Windows.Forms.Padding(2);
            this._chkHits.Name = "_chkHits";
            this._chkHits.Size = new System.Drawing.Size(90, 17);
            this._chkHits.TabIndex = 3;
            this._chkHits.Text = "Точки ударів";
            this._chkHits.UseVisualStyleBackColor = true;
            this._chkHits.CheckedChanged += new System.EventHandler(this._chk_CheckedChanged);
            // 
            // _chkGrid
            // 
            this._chkGrid.AutoSize = true;
            this._chkGrid.Checked = true;
            this._chkGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkGrid.Location = new System.Drawing.Point(65, 123);
            this._chkGrid.Margin = new System.Windows.Forms.Padding(2);
            this._chkGrid.Name = "_chkGrid";
            this._chkGrid.Size = new System.Drawing.Size(52, 17);
            this._chkGrid.TabIndex = 2;
            this._chkGrid.Text = "Сітка";
            this._chkGrid.UseVisualStyleBackColor = true;
            this._chkGrid.CheckedChanged += new System.EventHandler(this._chk_CheckedChanged);
            // 
            // _chkVector
            // 
            this._chkVector.AutoSize = true;
            this._chkVector.Checked = true;
            this._chkVector.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkVector.Location = new System.Drawing.Point(65, 92);
            this._chkVector.Margin = new System.Windows.Forms.Padding(2);
            this._chkVector.Name = "_chkVector";
            this._chkVector.Size = new System.Drawing.Size(116, 17);
            this._chkVector.TabIndex = 1;
            this._chkVector.Text = "Вектор швидкості";
            this._chkVector.UseVisualStyleBackColor = true;
            this._chkVector.CheckedChanged += new System.EventHandler(this._chk_CheckedChanged);
            // 
            // _chkTrail
            // 
            this._chkTrail.AutoSize = true;
            this._chkTrail.Checked = true;
            this._chkTrail.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkTrail.Location = new System.Drawing.Point(65, 62);
            this._chkTrail.Margin = new System.Windows.Forms.Padding(2);
            this._chkTrail.Name = "_chkTrail";
            this._chkTrail.Size = new System.Drawing.Size(47, 17);
            this._chkTrail.TabIndex = 0;
            this._chkTrail.Text = "Слід";
            this._chkTrail.UseVisualStyleBackColor = true;
            this._chkTrail.CheckedChanged += new System.EventHandler(this._chk_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this._clbCmp);
            this.tabPage3.Controls.Add(this._btnClearCmp);
            this.tabPage3.Controls.Add(this._btnAddCmp);
            this.tabPage3.Controls.Add(this._numTmax);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(246, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Порівняння";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // _clbCmp
            // 
            this._clbCmp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._clbCmp.FormattingEnabled = true;
            this._clbCmp.Location = new System.Drawing.Point(3, 388);
            this._clbCmp.Name = "_clbCmp";
            this._clbCmp.Size = new System.Drawing.Size(240, 139);
            this._clbCmp.TabIndex = 4;
            this._clbCmp.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this._clbCmp_ItemCheck);
            // 
            // _btnClearCmp
            // 
            this._btnClearCmp.Location = new System.Drawing.Point(60, 260);
            this._btnClearCmp.Name = "_btnClearCmp";
            this._btnClearCmp.Size = new System.Drawing.Size(131, 37);
            this._btnClearCmp.TabIndex = 3;
            this._btnClearCmp.Text = "Очистити";
            this._btnClearCmp.UseVisualStyleBackColor = true;
            this._btnClearCmp.Click += new System.EventHandler(this._btnClearCmp_Click);
            // 
            // _btnAddCmp
            // 
            this._btnAddCmp.Location = new System.Drawing.Point(60, 192);
            this._btnAddCmp.Name = "_btnAddCmp";
            this._btnAddCmp.Size = new System.Drawing.Size(131, 53);
            this._btnAddCmp.TabIndex = 2;
            this._btnAddCmp.Text = "Додати поточний запуск";
            this._btnAddCmp.UseVisualStyleBackColor = true;
            this._btnAddCmp.Click += new System.EventHandler(this._btnAddCmp_Click);
            // 
            // _numTmax
            // 
            this._numTmax.Location = new System.Drawing.Point(60, 133);
            this._numTmax.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this._numTmax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numTmax.Name = "_numTmax";
            this._numTmax.Size = new System.Drawing.Size(120, 20);
            this._numTmax.TabIndex = 1;
            this._numTmax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Час порівняння t_max";
            // 
            // _canvas
            // 
            this._canvas.BackColor = System.Drawing.Color.White;
            this._canvas.Location = new System.Drawing.Point(266, 15);
            this._canvas.Margin = new System.Windows.Forms.Padding(2);
            this._canvas.Name = "_canvas";
            this._canvas.Size = new System.Drawing.Size(811, 556);
            this._canvas.TabIndex = 2;
            this._canvas.Paint += new System.Windows.Forms.PaintEventHandler(this._canvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 590);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this._canvas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Відбиття кулі";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._trkSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numY0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numW)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numTmax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer _timer;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar _trkSpeed;
        private System.Windows.Forms.Button _btnStep;
        private System.Windows.Forms.CheckBox _chkTrail;
        private System.Windows.Forms.CheckBox _chkInfo;
        private System.Windows.Forms.CheckBox _chkHits;
        private System.Windows.Forms.CheckBox _chkGrid;
        private System.Windows.Forms.CheckBox _chkVector;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckedListBox _clbCmp;
        private System.Windows.Forms.Button _btnClearCmp;
        private System.Windows.Forms.Button _btnAddCmp;
        private System.Windows.Forms.NumericUpDown _numTmax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button _btnSavePng;
    }
}

