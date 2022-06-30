namespace Tes_App
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyEdgeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.houghTransformToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outputImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contourImagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianSmoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCannyDetection = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findCountourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showThresholdImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRoi = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnProcess = new System.Windows.Forms.Button();
            this.gbMainImage = new System.Windows.Forms.GroupBox();
            this.mainImageBox = new Emgu.CV.UI.ImageBox();
            this.gbProcessImage = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.processBox1 = new System.Windows.Forms.PictureBox();
            this.processBox2 = new System.Windows.Forms.PictureBox();
            this.processBox3 = new System.Windows.Forms.PictureBox();
            this.processBox4 = new System.Windows.Forms.PictureBox();
            this.gbOutputImage = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.outputImageBox = new System.Windows.Forms.PictureBox();
            this.gbInputImage = new System.Windows.Forms.GroupBox();
            this.inputImageBox = new System.Windows.Forms.PictureBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lamp = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuPose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbMainImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImageBox)).BeginInit();
            this.gbProcessImage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBox4)).BeginInit();
            this.gbOutputImage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputImageBox)).BeginInit();
            this.gbInputImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputImageBox)).BeginInit();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.menuConfig,
            this.viewToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.MenuSave,
            this.MenuSaveAs,
            this.MenuExit});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // MenuOpen
            // 
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(139, 22);
            this.MenuOpen.Text = "Open Image";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(139, 22);
            this.MenuSave.Text = "Save";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // MenuSaveAs
            // 
            this.MenuSaveAs.Name = "MenuSaveAs";
            this.MenuSaveAs.Size = new System.Drawing.Size(139, 22);
            this.MenuSaveAs.Text = "Save As";
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(139, 22);
            this.MenuExit.Text = "Exit";
            // 
            // menuConfig
            // 
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.ShowShortcutKeys = false;
            this.menuConfig.Size = new System.Drawing.Size(55, 20);
            this.menuConfig.Text = "Config";
            this.menuConfig.Click += new System.EventHandler(this.menuConfig_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleImageToolStripMenuItem,
            this.gaussianBlurImageToolStripMenuItem,
            this.cannyEdgeImageToolStripMenuItem,
            this.houghTransformToolStripMenuItem1,
            this.outputImageToolStripMenuItem,
            this.contourImagToolStripMenuItem,
            this.imgOutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // grayscaleImageToolStripMenuItem
            // 
            this.grayscaleImageToolStripMenuItem.Name = "grayscaleImageToolStripMenuItem";
            this.grayscaleImageToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.grayscaleImageToolStripMenuItem.Text = "Grayscale Image";
            // 
            // gaussianBlurImageToolStripMenuItem
            // 
            this.gaussianBlurImageToolStripMenuItem.Name = "gaussianBlurImageToolStripMenuItem";
            this.gaussianBlurImageToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gaussianBlurImageToolStripMenuItem.Text = "Gaussian Blur Image";
            // 
            // cannyEdgeImageToolStripMenuItem
            // 
            this.cannyEdgeImageToolStripMenuItem.Name = "cannyEdgeImageToolStripMenuItem";
            this.cannyEdgeImageToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cannyEdgeImageToolStripMenuItem.Text = "Canny Edge Image";
            // 
            // houghTransformToolStripMenuItem1
            // 
            this.houghTransformToolStripMenuItem1.Name = "houghTransformToolStripMenuItem1";
            this.houghTransformToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.houghTransformToolStripMenuItem1.Text = "Hough Transform";
            // 
            // outputImageToolStripMenuItem
            // 
            this.outputImageToolStripMenuItem.Name = "outputImageToolStripMenuItem";
            this.outputImageToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.outputImageToolStripMenuItem.Text = "Output Image";
            // 
            // contourImagToolStripMenuItem
            // 
            this.contourImagToolStripMenuItem.Name = "contourImagToolStripMenuItem";
            this.contourImagToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.contourImagToolStripMenuItem.Text = "Contour Image";
            // 
            // imgOutToolStripMenuItem
            // 
            this.imgOutToolStripMenuItem.Name = "imgOutToolStripMenuItem";
            this.imgOutToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.imgOutToolStripMenuItem.Text = "imgOut";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussianSmoothingToolStripMenuItem,
            this.gaussianToolStripMenuItem,
            this.menuPose});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // gaussianSmoothingToolStripMenuItem
            // 
            this.gaussianSmoothingToolStripMenuItem.Name = "gaussianSmoothingToolStripMenuItem";
            this.gaussianSmoothingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gaussianSmoothingToolStripMenuItem.Text = "Grayscale Image";
            // 
            // gaussianToolStripMenuItem
            // 
            this.gaussianToolStripMenuItem.Name = "gaussianToolStripMenuItem";
            this.gaussianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gaussianToolStripMenuItem.Text = "Gaussian";
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCannyDetection,
            this.laplacianToolStripMenuItem,
            this.findCountourToolStripMenuItem,
            this.menuRoi});
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            // 
            // MenuCannyDetection
            // 
            this.MenuCannyDetection.Name = "MenuCannyDetection";
            this.MenuCannyDetection.Size = new System.Drawing.Size(191, 22);
            this.MenuCannyDetection.Text = "Canny Edge Detection";
            this.MenuCannyDetection.Click += new System.EventHandler(this.MenuCannyDetection_Click);
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            // 
            // findCountourToolStripMenuItem
            // 
            this.findCountourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showThresholdImageToolStripMenuItem});
            this.findCountourToolStripMenuItem.Name = "findCountourToolStripMenuItem";
            this.findCountourToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.findCountourToolStripMenuItem.Text = "Find Contours";
            // 
            // showThresholdImageToolStripMenuItem
            // 
            this.showThresholdImageToolStripMenuItem.Name = "showThresholdImageToolStripMenuItem";
            this.showThresholdImageToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.showThresholdImageToolStripMenuItem.Text = "Show Threshold Image";
            // 
            // menuRoi
            // 
            this.menuRoi.Name = "menuRoi";
            this.menuRoi.Size = new System.Drawing.Size(191, 22);
            this.menuRoi.Text = "Set ROI";
            this.menuRoi.Click += new System.EventHandler(this.menuRoi_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(899, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 83);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scratch Detection :";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.BtnOpen, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnClear, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnProcess, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(262, 59);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOpen.Image = global::Tes_App.Properties.Resources.bmp_open_file_format__24_;
            this.BtnOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnOpen.Location = new System.Drawing.Point(3, 3);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(81, 53);
            this.BtnOpen.TabIndex = 0;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClear.Image = global::Tes_App.Properties.Resources.error__24_;
            this.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnClear.Location = new System.Drawing.Point(90, 3);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(81, 53);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Clear";
            this.BtnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnProcess
            // 
            this.BtnProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnProcess.Image = global::Tes_App.Properties.Resources.play_arrow__24_;
            this.BtnProcess.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProcess.Location = new System.Drawing.Point(177, 3);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(82, 53);
            this.BtnProcess.TabIndex = 2;
            this.BtnProcess.Text = "Process";
            this.BtnProcess.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnProcess.UseVisualStyleBackColor = true;
            this.BtnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // gbMainImage
            // 
            this.gbMainImage.Controls.Add(this.mainImageBox);
            this.gbMainImage.Enabled = false;
            this.gbMainImage.Location = new System.Drawing.Point(286, 27);
            this.gbMainImage.Name = "gbMainImage";
            this.gbMainImage.Size = new System.Drawing.Size(600, 400);
            this.gbMainImage.TabIndex = 3;
            this.gbMainImage.TabStop = false;
            this.gbMainImage.Text = "Image :";
            // 
            // mainImageBox
            // 
            this.mainImageBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mainImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainImageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.mainImageBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.mainImageBox.Location = new System.Drawing.Point(3, 16);
            this.mainImageBox.Name = "mainImageBox";
            this.mainImageBox.Size = new System.Drawing.Size(594, 381);
            this.mainImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainImageBox.TabIndex = 2;
            this.mainImageBox.TabStop = false;
            this.mainImageBox.DoubleClick += new System.EventHandler(this.mainImageBox_DoubleClick);
            // 
            // gbProcessImage
            // 
            this.gbProcessImage.Controls.Add(this.tableLayoutPanel1);
            this.gbProcessImage.Enabled = false;
            this.gbProcessImage.Location = new System.Drawing.Point(12, 433);
            this.gbProcessImage.Name = "gbProcessImage";
            this.gbProcessImage.Size = new System.Drawing.Size(673, 154);
            this.gbProcessImage.TabIndex = 4;
            this.gbProcessImage.TabStop = false;
            this.gbProcessImage.Text = "Process Image";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.processBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.processBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.processBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.processBox4, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 135);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // processBox1
            // 
            this.processBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.processBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processBox1.Location = new System.Drawing.Point(3, 3);
            this.processBox1.Name = "processBox1";
            this.processBox1.Size = new System.Drawing.Size(160, 129);
            this.processBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processBox1.TabIndex = 0;
            this.processBox1.TabStop = false;
            this.processBox1.Click += new System.EventHandler(this.processBox1_Click);
            // 
            // processBox2
            // 
            this.processBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.processBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processBox2.Location = new System.Drawing.Point(169, 3);
            this.processBox2.Name = "processBox2";
            this.processBox2.Size = new System.Drawing.Size(160, 129);
            this.processBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processBox2.TabIndex = 1;
            this.processBox2.TabStop = false;
            this.processBox2.Click += new System.EventHandler(this.processBox2_Click);
            // 
            // processBox3
            // 
            this.processBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.processBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processBox3.Location = new System.Drawing.Point(335, 3);
            this.processBox3.Name = "processBox3";
            this.processBox3.Size = new System.Drawing.Size(160, 129);
            this.processBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processBox3.TabIndex = 2;
            this.processBox3.TabStop = false;
            this.processBox3.Click += new System.EventHandler(this.processBox3_Click);
            // 
            // processBox4
            // 
            this.processBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.processBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processBox4.Location = new System.Drawing.Point(501, 3);
            this.processBox4.Name = "processBox4";
            this.processBox4.Size = new System.Drawing.Size(163, 129);
            this.processBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.processBox4.TabIndex = 3;
            this.processBox4.TabStop = false;
            this.processBox4.Click += new System.EventHandler(this.processBox4_Click);
            // 
            // gbOutputImage
            // 
            this.gbOutputImage.Controls.Add(this.tableLayoutPanel2);
            this.gbOutputImage.Enabled = false;
            this.gbOutputImage.Location = new System.Drawing.Point(691, 433);
            this.gbOutputImage.Name = "gbOutputImage";
            this.gbOutputImage.Size = new System.Drawing.Size(195, 154);
            this.gbOutputImage.TabIndex = 5;
            this.gbOutputImage.TabStop = false;
            this.gbOutputImage.Text = "Output :";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.outputImageBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(189, 135);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // outputImageBox
            // 
            this.outputImageBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.outputImageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outputImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputImageBox.Location = new System.Drawing.Point(3, 3);
            this.outputImageBox.Name = "outputImageBox";
            this.outputImageBox.Size = new System.Drawing.Size(183, 129);
            this.outputImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputImageBox.TabIndex = 0;
            this.outputImageBox.TabStop = false;
            this.outputImageBox.Click += new System.EventHandler(this.outputImageBox_Click);
            // 
            // gbInputImage
            // 
            this.gbInputImage.Controls.Add(this.inputImageBox);
            this.gbInputImage.Enabled = false;
            this.gbInputImage.Location = new System.Drawing.Point(12, 237);
            this.gbInputImage.Name = "gbInputImage";
            this.gbInputImage.Size = new System.Drawing.Size(268, 190);
            this.gbInputImage.TabIndex = 6;
            this.gbInputImage.TabStop = false;
            this.gbInputImage.Text = "Input Image :";
            // 
            // inputImageBox
            // 
            this.inputImageBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputImageBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputImageBox.Location = new System.Drawing.Point(3, 16);
            this.inputImageBox.Name = "inputImageBox";
            this.inputImageBox.Size = new System.Drawing.Size(262, 171);
            this.inputImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputImageBox.TabIndex = 0;
            this.inputImageBox.TabStop = false;
            this.inputImageBox.Click += new System.EventHandler(this.inputImageBox_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.lamp);
            this.gbResult.Controls.Add(this.richTextBox1);
            this.gbResult.Enabled = false;
            this.gbResult.Location = new System.Drawing.Point(12, 116);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(268, 115);
            this.gbResult.TabIndex = 7;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Results";
            // 
            // lamp
            // 
            this.lamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lamp.Dock = System.Windows.Forms.DockStyle.Right;
            this.lamp.Location = new System.Drawing.Point(223, 16);
            this.lamp.Name = "lamp";
            this.lamp.Size = new System.Drawing.Size(42, 96);
            this.lamp.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(214, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuPose
            // 
            this.menuPose.Name = "menuPose";
            this.menuPose.Size = new System.Drawing.Size(180, 22);
            this.menuPose.Text = "Pose Detection";
            this.menuPose.Click += new System.EventHandler(this.menuPose_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 615);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbInputImage);
            this.Controls.Add(this.gbOutputImage);
            this.Controls.Add(this.gbProcessImage);
            this.Controls.Add(this.gbMainImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AOI System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.gbMainImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainImageBox)).EndInit();
            this.gbProcessImage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBox4)).EndInit();
            this.gbOutputImage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outputImageBox)).EndInit();
            this.gbInputImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputImageBox)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianSmoothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCannyDetection;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnProcess;
        private System.Windows.Forms.GroupBox gbMainImage;
        private System.Windows.Forms.GroupBox gbProcessImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbOutputImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbInputImage;
        private System.Windows.Forms.GroupBox gbResult;
        private Emgu.CV.UI.ImageBox mainImageBox;
        private System.Windows.Forms.PictureBox processBox1;
        private System.Windows.Forms.PictureBox processBox2;
        private System.Windows.Forms.PictureBox processBox3;
        private System.Windows.Forms.PictureBox processBox4;
        private System.Windows.Forms.PictureBox outputImageBox;
        private System.Windows.Forms.PictureBox inputImageBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem findCountourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showThresholdImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyEdgeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem houghTransformToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem outputImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contourImagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imgOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRoi;
        private System.Windows.Forms.Panel lamp;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem menuPose;
    }
}