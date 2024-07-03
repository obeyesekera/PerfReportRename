using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PerfReportRename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtDirectoryPath.Enabled = false;
            pnlFileBox.Enabled = false;
        }

        private string rootDir;
        private string exRound = "R1_";
        private string exTPS = "TPS_1.0_";
        
        private void btnDirectoryPath_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.SelectedPath = txtDirectoryPath.Text;
            DialogResult drResult = folderBrowserDialog1.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
            {
                txtDirectoryPath.Text = folderBrowserDialog1.SelectedPath;
                
            }
            
            // Setting Inital Value of Progress Bar
            progressBar1.Value = 0;
            // Clear All Nodes if Already Exists
            treeView1.Nodes.Clear();
            toolTip1.ShowAlways = true;
            if (Directory.Exists(txtDirectoryPath.Text))
            {
                LoadDirectory(txtDirectoryPath.Text);
            }
            else
            {
                MessageBox.Show("Select Directory!!");
            }
        }

        private void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            //Setting ProgressBar Maximum Value
            progressBar1.Maximum = Directory.GetDirectories(Dir, "**", SearchOption.AllDirectories).Length;
            rootDir = di.Name;
            TreeNode tds = treeView1.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            //LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
            setDestinationPath(di.FullName);
            updateFileName("fileName");
            pnlFileBox.Enabled = true;
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                //LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
                UpdateProgress();
            }
            treeView1.ExpandAll();
        }

        private void UpdateProgress()
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
                progressBar1.CreateGraphics().DrawString(percent.ToString() + "%", new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));
                Application.DoEvents();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            setDestinationPath(treeView1.SelectedNode.FullPath.Replace(rootDir, txtDirectoryPath.Text));
            //setDestinationPath(treeView1.SelectedNode.FullPath);

            R1.Checked = true;
            TPS1_0.Checked = true;
            updateFileName("fileName");

        }

        private void setDestinationPath(string dPath)
        {
            txtDestinationDirectory.Text = dPath;

        }

        private void R1_CheckedChanged(object sender, EventArgs e)
        {
            if (R1.Checked)
            {
                exRound = "R1_";
                TPS1_0.Checked = true;
                updateFileName("fileName");
            }
        }

        private void R2_CheckedChanged(object sender, EventArgs e)
        {
            if (R2.Checked)
            {
                exRound = "R2_";
                TPS1_0.Checked = true;
                updateFileName("fileName");
            }
        }

        private void R3_CheckedChanged(object sender, EventArgs e)
        {
            if (R3.Checked)
            {
                exRound = "R3_";
                TPS1_0.Checked = true;
                updateFileName("fileName");
            }
        }

        private void TPS1_0_CheckedChanged(object sender, EventArgs e)
        {
            if (TPS1_0.Checked)
            {
                exTPS = "TPS_1.0_";
                updateFileName("fileName");
            }
        }

        private void TPS2_5_CheckedChanged(object sender, EventArgs e)
        {
            if (TPS2_5.Checked)
            {
                exTPS = "TPS_2.5_";
                updateFileName("fileName");
            }
        }

        private void TPS5_0_CheckedChanged(object sender, EventArgs e)
        {
            if (TPS5_0.Checked)
            {
                exTPS = "TPS_5.0_";
                updateFileName("fileName");
            }
        }

        private void updateFileName(string fName)
        {
            lblFileName.Text = exRound + exTPS + fName;
        }

        private void pnlFileBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                //TAKE dropped items and store in array.
                string[] dropppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

                //LOOP through all droppped items and display them
                foreach (string file in dropppedFiles)
                {
                    string filename = getFileName(file);
                    string newFile;
                    //listBox1.Items.Add(filename);
                    FileInfo fi = new FileInfo(file);
                    {
                        //IF filename "NewName" doesn't exist in drag drop box.
                        //if (!File.Exists("NewName"))
                        //{
                        //    getDirectoryName(filename);
                        //    fi.MoveTo("NewName");
                        //}

                        progressBar1.Maximum = (int)fi.Length;
                        progressBar1.Value = 0;

                        if (fi.Extension == ".pdf")
                        {
                            updateFileName("ServerStats.pdf");
                            newFile = txtDestinationDirectory.Text + "\\" + lblFileName.Text;
                            fi.CopyTo(newFile);
                        }

                        if (fi.Extension == ".zip")
                        {
                            updateFileName("Report.zip");
                            newFile = txtDestinationDirectory.Text + "\\" + lblFileName.Text;
                            fi.CopyTo(newFile);
                        }
                        progressBar1.Value = progressBar1.Maximum;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string getFileName(string path)
        {
            return Path.GetFileName(path);
        }

        private string getDirectoryName(string path)
        {
            return Path.GetDirectoryName(path);
        }

        private void pnlFileBox_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
