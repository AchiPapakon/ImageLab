namespace ImageLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGrayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeGrayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToYCbCrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blobbingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionepektashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syriknwshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prosanatolismosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.experimentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCbCrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = resources.GetString("openFileDialog1.Filter");
            this.openFileDialog1.FilterIndex = 7;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpeg)|*.jpeg|GIF (*.gif)|*.gif| TIFF (*.tif;*.tiff)|" +
                "*.tif;*.tiff|PNG (*.png)|*.png|ICO (*.ico)|*.ico";
            this.saveFileDialog1.FilterIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpen,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // FileOpen
            // 
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.Size = new System.Drawing.Size(103, 22);
            this.FileOpen.Text = "Open";
            this.FileOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // processingToolStripMenuItem
            // 
            this.processingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertToolStripMenuItem,
            this.rGBComponentsToolStripMenuItem,
            this.editGrayscaleToolStripMenuItem,
            this.binarizationToolStripMenuItem,
            this.convertToYCbCrToolStripMenuItem,
            this.blobbingToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.processingToolStripMenuItem.Enabled = false;
            this.processingToolStripMenuItem.Name = "processingToolStripMenuItem";
            this.processingToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.processingToolStripMenuItem.Text = "Processing";
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gDIToolStripMenuItem,
            this.pointersToolStripMenuItem});
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.invertToolStripMenuItem.Text = "Invert";
            // 
            // gDIToolStripMenuItem
            // 
            this.gDIToolStripMenuItem.Name = "gDIToolStripMenuItem";
            this.gDIToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.gDIToolStripMenuItem.Text = "GDI+";
            this.gDIToolStripMenuItem.Click += new System.EventHandler(this.gDIToolStripMenuItem_Click);
            // 
            // pointersToolStripMenuItem
            // 
            this.pointersToolStripMenuItem.Name = "pointersToolStripMenuItem";
            this.pointersToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.pointersToolStripMenuItem.Text = "Pointers";
            this.pointersToolStripMenuItem.Click += new System.EventHandler(this.pointersToolStripMenuItem_Click);
            // 
            // rGBComponentsToolStripMenuItem
            // 
            this.rGBComponentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rToolStripMenuItem,
            this.gToolStripMenuItem,
            this.bToolStripMenuItem});
            this.rGBComponentsToolStripMenuItem.Name = "rGBComponentsToolStripMenuItem";
            this.rGBComponentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.rGBComponentsToolStripMenuItem.Text = "RGB Components";
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.rToolStripMenuItem.Text = "R";
            this.rToolStripMenuItem.Click += new System.EventHandler(this.rToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.gToolStripMenuItem.Text = "G";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.bToolStripMenuItem.Text = "B";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // editGrayscaleToolStripMenuItem
            // 
            this.editGrayscaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeGrayscaleToolStripMenuItem,
            this.makeRedToolStripMenuItem,
            this.makeGreenToolStripMenuItem,
            this.makeBlueToolStripMenuItem});
            this.editGrayscaleToolStripMenuItem.Name = "editGrayscaleToolStripMenuItem";
            this.editGrayscaleToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editGrayscaleToolStripMenuItem.Text = "Edit Grayscale";
            // 
            // makeGrayscaleToolStripMenuItem
            // 
            this.makeGrayscaleToolStripMenuItem.Name = "makeGrayscaleToolStripMenuItem";
            this.makeGrayscaleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.makeGrayscaleToolStripMenuItem.Text = "Make Grayscale";
            this.makeGrayscaleToolStripMenuItem.Click += new System.EventHandler(this.makeGrayscaleToolStripMenuItem_Click);
            // 
            // makeRedToolStripMenuItem
            // 
            this.makeRedToolStripMenuItem.Name = "makeRedToolStripMenuItem";
            this.makeRedToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.makeRedToolStripMenuItem.Text = "Red Tone";
            this.makeRedToolStripMenuItem.Click += new System.EventHandler(this.makeRedToolStripMenuItem_Click);
            // 
            // makeGreenToolStripMenuItem
            // 
            this.makeGreenToolStripMenuItem.Name = "makeGreenToolStripMenuItem";
            this.makeGreenToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.makeGreenToolStripMenuItem.Text = "Green Tone";
            this.makeGreenToolStripMenuItem.Click += new System.EventHandler(this.makeGreenToolStripMenuItem_Click);
            // 
            // makeBlueToolStripMenuItem
            // 
            this.makeBlueToolStripMenuItem.Name = "makeBlueToolStripMenuItem";
            this.makeBlueToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.makeBlueToolStripMenuItem.Text = "Blue Tone";
            this.makeBlueToolStripMenuItem.Click += new System.EventHandler(this.makeBlueToolStripMenuItem_Click);
            // 
            // binarizationToolStripMenuItem
            // 
            this.binarizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thresholdToolStripMenuItem});
            this.binarizationToolStripMenuItem.Name = "binarizationToolStripMenuItem";
            this.binarizationToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.binarizationToolStripMenuItem.Text = "Binarization";
            // 
            // thresholdToolStripMenuItem
            // 
            this.thresholdToolStripMenuItem.Name = "thresholdToolStripMenuItem";
            this.thresholdToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.thresholdToolStripMenuItem.Text = "Threshold";
            this.thresholdToolStripMenuItem.Click += new System.EventHandler(this.thresholdToolStripMenuItem_Click);
            // 
            // convertToYCbCrToolStripMenuItem
            // 
            this.convertToYCbCrToolStripMenuItem.Name = "convertToYCbCrToolStripMenuItem";
            this.convertToYCbCrToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.convertToYCbCrToolStripMenuItem.Text = "Convert to YCbCr";
            this.convertToYCbCrToolStripMenuItem.Click += new System.EventHandler(this.convertToYCbCrToolStripMenuItem_Click);
            // 
            // blobbingToolStripMenuItem
            // 
            this.blobbingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erosionepektashToolStripMenuItem,
            this.syriknwshToolStripMenuItem,
            this.prosanatolismosToolStripMenuItem});
            this.blobbingToolStripMenuItem.Name = "blobbingToolStripMenuItem";
            this.blobbingToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.blobbingToolStripMenuItem.Text = "Blobbing";
            // 
            // erosionepektashToolStripMenuItem
            // 
            this.erosionepektashToolStripMenuItem.Name = "erosionepektashToolStripMenuItem";
            this.erosionepektashToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.erosionepektashToolStripMenuItem.Text = "Erosion (Syriknwsh)";
            this.erosionepektashToolStripMenuItem.Click += new System.EventHandler(this.erosionepektashToolStripMenuItem_Click);
            // 
            // syriknwshToolStripMenuItem
            // 
            this.syriknwshToolStripMenuItem.Name = "syriknwshToolStripMenuItem";
            this.syriknwshToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.syriknwshToolStripMenuItem.Text = "Delation (Epektash)";
            this.syriknwshToolStripMenuItem.Click += new System.EventHandler(this.syriknwshToolStripMenuItem_Click);
            // 
            // prosanatolismosToolStripMenuItem
            // 
            this.prosanatolismosToolStripMenuItem.Name = "prosanatolismosToolStripMenuItem";
            this.prosanatolismosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.prosanatolismosToolStripMenuItem.Text = "prosanatolismos";
            this.prosanatolismosToolStripMenuItem.Click += new System.EventHandler(this.prosanatolismosToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analysisToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.analysisToolStripMenuItem.Text = "Analysis";
            this.analysisToolStripMenuItem.Click += new System.EventHandler(this.analysisToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processingToolStripMenuItem,
            this.experimentalToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // experimentalToolStripMenuItem
            // 
            this.experimentalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureToolStripMenuItem,
            this.clearCbCrToolStripMenuItem});
            this.experimentalToolStripMenuItem.Enabled = false;
            this.experimentalToolStripMenuItem.Name = "experimentalToolStripMenuItem";
            this.experimentalToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.experimentalToolStripMenuItem.Text = "Experimental";
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.captureToolStripMenuItem.Text = "Capture";
            this.captureToolStripMenuItem.Click += new System.EventHandler(this.captureToolStripMenuItem_Click_1);
            // 
            // clearCbCrToolStripMenuItem
            // 
            this.clearCbCrToolStripMenuItem.Name = "clearCbCrToolStripMenuItem";
            this.clearCbCrToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.clearCbCrToolStripMenuItem.Text = "Clear Cb/Cr";
            this.clearCbCrToolStripMenuItem.Click += new System.EventHandler(this.clearCbCrToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Restore to Original";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minToolStripMenuItem,
            this.maxToolStripMenuItem,
            this.meanToolStripMenuItem,
            this.medianToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minToolStripMenuItem.Text = "Min";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.minToolStripMenuItem_Click);
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.maxToolStripMenuItem.Text = "Max";
            this.maxToolStripMenuItem.Click += new System.EventHandler(this.maxToolStripMenuItem_Click);
            // 
            // meanToolStripMenuItem
            // 
            this.meanToolStripMenuItem.Name = "meanToolStripMenuItem";
            this.meanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.meanToolStripMenuItem.Text = "Mean";
            this.meanToolStripMenuItem.Click += new System.EventHandler(this.meanToolStripMenuItem_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.medianToolStripMenuItem.Text = "Median";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1065, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ImageLab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileOpen;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBComponentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGrayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeGrayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeGreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToYCbCrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem blobbingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syriknwshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prosanatolismosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionepektashToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem experimentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCbCrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
    }
}

