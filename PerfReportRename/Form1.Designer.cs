
namespace PerfReportRename
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.btnDirectoryPath = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblDestinationDirectory = new System.Windows.Forms.Label();
            this.txtDestinationDirectory = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.R3 = new System.Windows.Forms.RadioButton();
            this.R2 = new System.Windows.Forms.RadioButton();
            this.R1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TPS5_0 = new System.Windows.Forms.RadioButton();
            this.TPS2_5 = new System.Windows.Forms.RadioButton();
            this.TPS1_0 = new System.Windows.Forms.RadioButton();
            this.pnlFileBox = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(12, 50);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(401, 434);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Location = new System.Drawing.Point(13, 13);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(486, 33);
            this.txtDirectoryPath.TabIndex = 1;
            // 
            // btnDirectoryPath
            // 
            this.btnDirectoryPath.Location = new System.Drawing.Point(506, 11);
            this.btnDirectoryPath.Name = "btnDirectoryPath";
            this.btnDirectoryPath.Size = new System.Drawing.Size(34, 34);
            this.btnDirectoryPath.TabIndex = 2;
            this.btnDirectoryPath.Text = "...";
            this.btnDirectoryPath.UseVisualStyleBackColor = true;
            this.btnDirectoryPath.Click += new System.EventHandler(this.btnDirectoryPath_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(547, 11);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(241, 34);
            this.progressBar1.TabIndex = 3;
            // 
            // lblDestinationDirectory
            // 
            this.lblDestinationDirectory.AutoEllipsis = true;
            this.lblDestinationDirectory.AutoSize = true;
            this.lblDestinationDirectory.Location = new System.Drawing.Point(12, 499);
            this.lblDestinationDirectory.Name = "lblDestinationDirectory";
            this.lblDestinationDirectory.Size = new System.Drawing.Size(150, 25);
            this.lblDestinationDirectory.TabIndex = 4;
            this.lblDestinationDirectory.Text = "Destination Path";
            // 
            // txtDestinationDirectory
            // 
            this.txtDestinationDirectory.Enabled = false;
            this.txtDestinationDirectory.Location = new System.Drawing.Point(12, 527);
            this.txtDestinationDirectory.Multiline = true;
            this.txtDestinationDirectory.Name = "txtDestinationDirectory";
            this.txtDestinationDirectory.Size = new System.Drawing.Size(776, 76);
            this.txtDestinationDirectory.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.R3);
            this.panel1.Controls.Add(this.R2);
            this.panel1.Controls.Add(this.R1);
            this.panel1.Location = new System.Drawing.Point(429, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 57);
            this.panel1.TabIndex = 6;
            // 
            // R3
            // 
            this.R3.AutoSize = true;
            this.R3.Location = new System.Drawing.Point(140, 14);
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(58, 29);
            this.R3.TabIndex = 2;
            this.R3.Text = "R3";
            this.R3.UseVisualStyleBackColor = true;
            this.R3.CheckedChanged += new System.EventHandler(this.R3_CheckedChanged);
            // 
            // R2
            // 
            this.R2.AutoSize = true;
            this.R2.Location = new System.Drawing.Point(76, 14);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(58, 29);
            this.R2.TabIndex = 1;
            this.R2.Text = "R2";
            this.R2.UseVisualStyleBackColor = true;
            this.R2.CheckedChanged += new System.EventHandler(this.R2_CheckedChanged);
            // 
            // R1
            // 
            this.R1.AutoSize = true;
            this.R1.Checked = true;
            this.R1.Location = new System.Drawing.Point(12, 14);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(58, 29);
            this.R1.TabIndex = 0;
            this.R1.TabStop = true;
            this.R1.Text = "R1";
            this.R1.UseVisualStyleBackColor = true;
            this.R1.CheckedChanged += new System.EventHandler(this.R1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TPS5_0);
            this.panel2.Controls.Add(this.TPS2_5);
            this.panel2.Controls.Add(this.TPS1_0);
            this.panel2.Location = new System.Drawing.Point(429, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 62);
            this.panel2.TabIndex = 7;
            // 
            // TPS5_0
            // 
            this.TPS5_0.AutoSize = true;
            this.TPS5_0.Location = new System.Drawing.Point(220, 18);
            this.TPS5_0.Name = "TPS5_0";
            this.TPS5_0.Size = new System.Drawing.Size(92, 29);
            this.TPS5_0.TabIndex = 2;
            this.TPS5_0.Text = "TPS5.0";
            this.TPS5_0.UseVisualStyleBackColor = true;
            this.TPS5_0.CheckedChanged += new System.EventHandler(this.TPS5_0_CheckedChanged);
            // 
            // TPS2_5
            // 
            this.TPS2_5.AutoSize = true;
            this.TPS2_5.Location = new System.Drawing.Point(114, 18);
            this.TPS2_5.Name = "TPS2_5";
            this.TPS2_5.Size = new System.Drawing.Size(92, 29);
            this.TPS2_5.TabIndex = 1;
            this.TPS2_5.Text = "TPS2.5";
            this.TPS2_5.UseVisualStyleBackColor = true;
            this.TPS2_5.CheckedChanged += new System.EventHandler(this.TPS2_5_CheckedChanged);
            // 
            // TPS1_0
            // 
            this.TPS1_0.AutoSize = true;
            this.TPS1_0.Checked = true;
            this.TPS1_0.Location = new System.Drawing.Point(12, 18);
            this.TPS1_0.Name = "TPS1_0";
            this.TPS1_0.Size = new System.Drawing.Size(92, 29);
            this.TPS1_0.TabIndex = 0;
            this.TPS1_0.TabStop = true;
            this.TPS1_0.Text = "TPS1.0";
            this.TPS1_0.UseVisualStyleBackColor = true;
            this.TPS1_0.CheckedChanged += new System.EventHandler(this.TPS1_0_CheckedChanged);
            // 
            // pnlFileBox
            // 
            this.pnlFileBox.AllowDrop = true;
            this.pnlFileBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlFileBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFileBox.Location = new System.Drawing.Point(429, 215);
            this.pnlFileBox.Name = "pnlFileBox";
            this.pnlFileBox.Size = new System.Drawing.Size(359, 269);
            this.pnlFileBox.TabIndex = 8;
            this.pnlFileBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlFileBox_DragDrop);
            this.pnlFileBox.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlFileBox_DragOver);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(429, 499);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(91, 25);
            this.lblFileName.TabIndex = 9;
            this.lblFileName.Text = "FileName";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.pnlFileBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDestinationDirectory);
            this.Controls.Add(this.lblDestinationDirectory);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnDirectoryPath);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Perf Report Organizer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Button btnDirectoryPath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDestinationDirectory;
        private System.Windows.Forms.TextBox txtDestinationDirectory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton R3;
        private System.Windows.Forms.RadioButton R2;
        private System.Windows.Forms.RadioButton R1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton TPS5_0;
        private System.Windows.Forms.RadioButton TPS2_5;
        private System.Windows.Forms.RadioButton TPS1_0;
        private System.Windows.Forms.Panel pnlFileBox;
        private System.Windows.Forms.Label lblFileName;
    }
}

