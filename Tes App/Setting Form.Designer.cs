namespace Tes_App
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numSigmaY = new System.Windows.Forms.NumericUpDown();
            this.numSigmaX = new System.Windows.Forms.NumericUpDown();
            this.numKernel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numThresholdH = new System.Windows.Forms.NumericUpDown();
            this.Threshold = new System.Windows.Forms.Label();
            this.numThresholdL = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numRoiH = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numRoiY = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numRoiW = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numRoiX = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numDilation = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.num_min = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.num_max = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSigmaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigmaX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKernel)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThresholdH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThresholdL)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoiH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoiY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoiW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoiX)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDilation)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numSigmaY);
            this.groupBox1.Controls.Add(this.numSigmaX);
            this.groupBox1.Controls.Add(this.numKernel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gaussian Smoothing";
            // 
            // numSigmaY
            // 
            this.numSigmaY.Location = new System.Drawing.Point(81, 72);
            this.numSigmaY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSigmaY.Name = "numSigmaY";
            this.numSigmaY.Size = new System.Drawing.Size(60, 20);
            this.numSigmaY.TabIndex = 14;
            this.numSigmaY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numSigmaX
            // 
            this.numSigmaX.DecimalPlaces = 1;
            this.numSigmaX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSigmaX.Location = new System.Drawing.Point(81, 46);
            this.numSigmaX.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numSigmaX.Name = "numSigmaX";
            this.numSigmaX.Size = new System.Drawing.Size(60, 20);
            this.numSigmaX.TabIndex = 13;
            this.numSigmaX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSigmaX.Value = new decimal(new int[] {
            14,
            0,
            0,
            65536});
            this.numSigmaX.ValueChanged += new System.EventHandler(this.numSigmaX_ValueChanged);
            // 
            // numKernel
            // 
            this.numKernel.Location = new System.Drawing.Point(81, 20);
            this.numKernel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numKernel.Name = "numKernel";
            this.numKernel.Size = new System.Drawing.Size(60, 20);
            this.numKernel.TabIndex = 12;
            this.numKernel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numKernel.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sigma Y :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sigma X :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kernel Size :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numThresholdH);
            this.groupBox3.Controls.Add(this.Threshold);
            this.groupBox3.Controls.Add(this.numThresholdL);
            this.groupBox3.Location = new System.Drawing.Point(3, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 82);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Canny Edge Detection";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Threshold H:";
            // 
            // numThresholdH
            // 
            this.numThresholdH.Location = new System.Drawing.Point(81, 53);
            this.numThresholdH.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numThresholdH.Name = "numThresholdH";
            this.numThresholdH.Size = new System.Drawing.Size(60, 20);
            this.numThresholdH.TabIndex = 2;
            this.numThresholdH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numThresholdH.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // Threshold
            // 
            this.Threshold.AutoSize = true;
            this.Threshold.Location = new System.Drawing.Point(6, 29);
            this.Threshold.Name = "Threshold";
            this.Threshold.Size = new System.Drawing.Size(69, 13);
            this.Threshold.TabIndex = 1;
            this.Threshold.Text = "Threshold L :";
            // 
            // numThresholdL
            // 
            this.numThresholdL.Location = new System.Drawing.Point(81, 27);
            this.numThresholdL.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numThresholdL.Name = "numThresholdL";
            this.numThresholdL.Size = new System.Drawing.Size(60, 20);
            this.numThresholdL.TabIndex = 0;
            this.numThresholdL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numThresholdL.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numThresholdL.ValueChanged += new System.EventHandler(this.numThresholdL_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numericUpDown7);
            this.groupBox2.Controls.Add(this.numericUpDown5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericUpDown6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(164, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 193);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hough Transform";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Gap :";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(83, 128);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown7.TabIndex = 13;
            this.numericUpDown7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown7.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(83, 102);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown5.TabIndex = 12;
            this.numericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown5.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Min. Length :";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(83, 76);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown6.TabIndex = 11;
            this.numericUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown6.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Threshold :";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 1;
            this.numericUpDown4.Location = new System.Drawing.Point(83, 50);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown4.TabIndex = 10;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown4.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tetha :";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(83, 24);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown3.TabIndex = 9;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rho :";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(429, 313);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(348, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 304);
            this.panel1.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.numRoiH);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.numRoiY);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.numRoiW);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.numRoiX);
            this.groupBox5.Location = new System.Drawing.Point(164, 202);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(192, 86);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ROI";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(101, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "h :";
            // 
            // numRoiH
            // 
            this.numRoiH.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRoiH.Location = new System.Drawing.Point(126, 45);
            this.numRoiH.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numRoiH.Name = "numRoiH";
            this.numRoiH.Size = new System.Drawing.Size(60, 20);
            this.numRoiH.TabIndex = 6;
            this.numRoiH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "y :";
            // 
            // numRoiY
            // 
            this.numRoiY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRoiY.Location = new System.Drawing.Point(31, 45);
            this.numRoiY.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numRoiY.Name = "numRoiY";
            this.numRoiY.Size = new System.Drawing.Size(60, 20);
            this.numRoiY.TabIndex = 4;
            this.numRoiY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(101, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "w :";
            // 
            // numRoiW
            // 
            this.numRoiW.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRoiW.Location = new System.Drawing.Point(126, 19);
            this.numRoiW.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numRoiW.Name = "numRoiW";
            this.numRoiW.Size = new System.Drawing.Size(60, 20);
            this.numRoiW.TabIndex = 2;
            this.numRoiW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "x :";
            // 
            // numRoiX
            // 
            this.numRoiX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRoiX.Location = new System.Drawing.Point(31, 19);
            this.numRoiX.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numRoiX.Name = "numRoiX";
            this.numRoiX.Size = new System.Drawing.Size(60, 20);
            this.numRoiX.TabIndex = 0;
            this.numRoiX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.numDilation);
            this.groupBox4.Location = new System.Drawing.Point(3, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 86);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dilation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Iteration :";
            // 
            // numDilation
            // 
            this.numDilation.Location = new System.Drawing.Point(81, 27);
            this.numDilation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numDilation.Name = "numDilation";
            this.numDilation.Size = new System.Drawing.Size(60, 20);
            this.numDilation.TabIndex = 0;
            this.numDilation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDilation.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDilation.ValueChanged += new System.EventHandler(this.numDilation_ValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.num_max);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.num_min);
            this.groupBox6.Location = new System.Drawing.Point(362, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(131, 102);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Defect Size Filtering";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Min :";
            // 
            // num_min
            // 
            this.num_min.Location = new System.Drawing.Point(60, 27);
            this.num_min.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_min.Name = "num_min";
            this.num_min.Size = new System.Drawing.Size(60, 20);
            this.num_min.TabIndex = 0;
            this.num_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_min.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Max :";
            // 
            // num_max
            // 
            this.num_max.Location = new System.Drawing.Point(60, 53);
            this.num_max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_max.Name = "num_max";
            this.num_max.Size = new System.Drawing.Size(60, 20);
            this.num_max.TabIndex = 2;
            this.num_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_max.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.Text = "Scartch Detection Setting";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSigmaY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigmaX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKernel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThresholdH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThresholdL)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoiH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoiY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoiW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoiX)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDilation)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numThresholdH;
        private System.Windows.Forms.Label Threshold;
        private System.Windows.Forms.NumericUpDown numThresholdL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown numSigmaY;
        private System.Windows.Forms.NumericUpDown numSigmaX;
        private System.Windows.Forms.NumericUpDown numKernel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numDilation;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numRoiH;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numRoiY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numRoiW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numRoiX;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown num_max;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown num_min;
    }
}