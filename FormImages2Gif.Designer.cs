namespace Images2Gif
{
    partial class FormImages2Gif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImages2Gif));
            this.txtSourceImagesDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaveAsGifInDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGifFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSourceImagesDirectory = new System.Windows.Forms.Button();
            this.btnBrowseSaveAsGifInDirectory = new System.Windows.Forms.Button();
            this.chkPNG = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkJPG = new System.Windows.Forms.CheckBox();
            this.chkBMP = new System.Windows.Forms.CheckBox();
            this.txtUserDefinedTypes = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkRepeat = new System.Windows.Forms.CheckBox();
            this.numFrameDelay = new System.Windows.Forms.NumericUpDown();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numFrameDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSourceImagesDirectory
            // 
            this.txtSourceImagesDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceImagesDirectory.Location = new System.Drawing.Point(179, 12);
            this.txtSourceImagesDirectory.Name = "txtSourceImagesDirectory";
            this.txtSourceImagesDirectory.ReadOnly = true;
            this.txtSourceImagesDirectory.Size = new System.Drawing.Size(483, 21);
            this.txtSourceImagesDirectory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "source images directory: ";
            // 
            // txtSaveAsGifInDirectory
            // 
            this.txtSaveAsGifInDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveAsGifInDirectory.Location = new System.Drawing.Point(179, 39);
            this.txtSaveAsGifInDirectory.Name = "txtSaveAsGifInDirectory";
            this.txtSaveAsGifInDirectory.ReadOnly = true;
            this.txtSaveAsGifInDirectory.Size = new System.Drawing.Size(483, 21);
            this.txtSaveAsGifInDirectory.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "save as gif in directory: ";
            // 
            // txtGifFileName
            // 
            this.txtGifFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGifFileName.Location = new System.Drawing.Point(179, 66);
            this.txtGifFileName.Name = "txtGifFileName";
            this.txtGifFileName.Size = new System.Drawing.Size(483, 21);
            this.txtGifFileName.TabIndex = 0;
            this.txtGifFileName.Text = "bitzhuwei.cnblogs.com.gif";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "gif file name: ";
            // 
            // btnSourceImagesDirectory
            // 
            this.btnSourceImagesDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSourceImagesDirectory.Location = new System.Drawing.Point(668, 10);
            this.btnSourceImagesDirectory.Name = "btnSourceImagesDirectory";
            this.btnSourceImagesDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnSourceImagesDirectory.TabIndex = 2;
            this.btnSourceImagesDirectory.Text = "browse...";
            this.btnSourceImagesDirectory.UseVisualStyleBackColor = true;
            this.btnSourceImagesDirectory.Click += new System.EventHandler(this.btnSourceImagesDirectory_Click);
            // 
            // btnBrowseSaveAsGifInDirectory
            // 
            this.btnBrowseSaveAsGifInDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSaveAsGifInDirectory.Location = new System.Drawing.Point(668, 37);
            this.btnBrowseSaveAsGifInDirectory.Name = "btnBrowseSaveAsGifInDirectory";
            this.btnBrowseSaveAsGifInDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSaveAsGifInDirectory.TabIndex = 2;
            this.btnBrowseSaveAsGifInDirectory.Text = "browse...";
            this.btnBrowseSaveAsGifInDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseSaveAsGifInDirectory.Click += new System.EventHandler(this.btnBrowseSaveAsGifInDirectory_Click);
            // 
            // chkPNG
            // 
            this.chkPNG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPNG.AutoSize = true;
            this.chkPNG.Location = new System.Drawing.Point(528, 96);
            this.chkPNG.Name = "chkPNG";
            this.chkPNG.Size = new System.Drawing.Size(42, 16);
            this.chkPNG.TabIndex = 3;
            this.chkPNG.Text = "PNG";
            this.chkPNG.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "source images types; ";
            // 
            // chkJPG
            // 
            this.chkJPG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkJPG.AutoSize = true;
            this.chkJPG.Location = new System.Drawing.Point(576, 96);
            this.chkJPG.Name = "chkJPG";
            this.chkJPG.Size = new System.Drawing.Size(42, 16);
            this.chkJPG.TabIndex = 3;
            this.chkJPG.Text = "JPG";
            this.chkJPG.UseVisualStyleBackColor = true;
            // 
            // chkBMP
            // 
            this.chkBMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBMP.AutoSize = true;
            this.chkBMP.Location = new System.Drawing.Point(624, 96);
            this.chkBMP.Name = "chkBMP";
            this.chkBMP.Size = new System.Drawing.Size(42, 16);
            this.chkBMP.TabIndex = 3;
            this.chkBMP.Text = "BMP";
            this.chkBMP.UseVisualStyleBackColor = true;
            // 
            // txtUserDefinedTypes
            // 
            this.txtUserDefinedTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserDefinedTypes.Location = new System.Drawing.Point(179, 91);
            this.txtUserDefinedTypes.Name = "txtUserDefinedTypes";
            this.txtUserDefinedTypes.Size = new System.Drawing.Size(343, 21);
            this.txtUserDefinedTypes.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(668, 180);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "frame delay: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "repeat: ";
            // 
            // chkRepeat
            // 
            this.chkRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRepeat.AutoSize = true;
            this.chkRepeat.Checked = true;
            this.chkRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRepeat.Location = new System.Drawing.Point(179, 149);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.Size = new System.Drawing.Size(60, 16);
            this.chkRepeat.TabIndex = 3;
            this.chkRepeat.Text = "repeat";
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // numFrameDelay
            // 
            this.numFrameDelay.Location = new System.Drawing.Point(179, 118);
            this.numFrameDelay.Name = "numFrameDelay";
            this.numFrameDelay.Size = new System.Drawing.Size(60, 21);
            this.numFrameDelay.TabIndex = 4;
            this.numFrameDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(14, 180);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(648, 23);
            this.prgBar.TabIndex = 5;
            this.prgBar.Visible = false;
            // 
            // FormImages2Gif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 215);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.numFrameDelay);
            this.Controls.Add(this.chkBMP);
            this.Controls.Add(this.chkJPG);
            this.Controls.Add(this.chkRepeat);
            this.Controls.Add(this.chkPNG);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowseSaveAsGifInDirectory);
            this.Controls.Add(this.btnSourceImagesDirectory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserDefinedTypes);
            this.Controls.Add(this.txtGifFileName);
            this.Controls.Add(this.txtSaveAsGifInDirectory);
            this.Controls.Add(this.txtSourceImagesDirectory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImages2Gif";
            this.Text = "Images to Gif by http://bitzhuwei.cnblogs.com";
            ((System.ComponentModel.ISupportInitialize)(this.numFrameDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceImagesDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaveAsGifInDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGifFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSourceImagesDirectory;
        private System.Windows.Forms.Button btnBrowseSaveAsGifInDirectory;
        private System.Windows.Forms.CheckBox chkPNG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkJPG;
        private System.Windows.Forms.CheckBox chkBMP;
        private System.Windows.Forms.TextBox txtUserDefinedTypes;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkRepeat;
        private System.Windows.Forms.NumericUpDown numFrameDelay;
        private System.Windows.Forms.ProgressBar prgBar;
    }
}