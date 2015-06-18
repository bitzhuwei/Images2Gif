using Gif.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images2Gif
{
    public partial class FormImages2Gif : Form
    {
        public FormImages2Gif()
        {
            InitializeComponent();
        }

        private void btnSourceImagesDirectory_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtSourceImagesDirectory.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBrowseSaveAsGifInDirectory_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtSaveAsGifInDirectory.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.worker.IsBusy)
            {
                MessageBox.Show("The routine is busy working on last job, please wait...");
                return;
            }

            if (!Directory.Exists(this.txtSourceImagesDirectory.Text))
            {
                MessageBox.Show("Invalid source images directory!");
                return;
            }

            if (!Directory.Exists(this.txtSaveAsGifInDirectory.Text))
            {
                MessageBox.Show("Invalid save as gif directory!");
                return;
            }

            if (string.IsNullOrEmpty(this.txtGifFileName.Text.Trim()))
            {
                MessageBox.Show("Invalid gif file name!");
                return;
            }

            List<string> imageTypes = GetImageTypes();
            if (imageTypes.Count == 0)
            {
                MessageBox.Show("Please choose or define at lease 1 image type!");
                return;
            }

            WorkArugment arg = new WorkArugment(this.txtSourceImagesDirectory.Text,
                this.txtSaveAsGifInDirectory.Text,
                this.txtGifFileName.Text,
                imageTypes,
                (int)this.numFrameDelay.Value,
                this.chkRepeat.Checked);
            this.btnStart.Text = "Working...";
            this.prgBar.Visible = true;
            this.worker.RunWorkerAsync(arg);
        }

        static readonly char[] separator = new char[] { ',', ' ' };

        List<string> GetImageTypes()
        {
            List<string> imageTypes = new List<string>();
            string[] userDefinedTypes = this.txtUserDefinedTypes.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in userDefinedTypes)
            {
                string lower = item.ToLower();
                if (!imageTypes.Contains(lower))
                {
                    imageTypes.Add(lower);
                }
            }

            if (chkPNG.Checked)
            {
                if (!imageTypes.Contains("png"))
                {
                    imageTypes.Add("png");
                }
            }

            if (chkJPG.Checked)
            {
                if (!imageTypes.Contains("jpg"))
                {
                    imageTypes.Add("jpg");
                }
            }

            if (chkBMP.Checked)
            {
                if (!imageTypes.Contains("bmp"))
                {
                    imageTypes.Add("bmp");
                }
            }


            return imageTypes;
        }

        class WorkArugment
        {
            public string sourceImagesDirectory;
            public string saveAsGifInDirectory;
            public string gifFileName;
            public List<string> imageTypes;
            public int frameDelay;
            public bool repeat;

            public WorkArugment(string sourceImagesDirectory, string saveAsGifInDirectory, string gifFileName, List<string> imageTypes, int frameDelay, bool repeat)
            {
                this.sourceImagesDirectory = sourceImagesDirectory;
                this.saveAsGifInDirectory = saveAsGifInDirectory;
                this.gifFileName = gifFileName;
                this.imageTypes = imageTypes;
                this.frameDelay = frameDelay;
                this.repeat = repeat;
            }

        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            WorkArugment arg = e.Argument as WorkArugment;

            //一般文件名按顺序排
            List<string> files = new List<string>();
            foreach (var item in arg.imageTypes)
            {
                string[] someTypeFiles = Directory.GetFileSystemEntries(arg.sourceImagesDirectory,
                    string.Format("*.{0}", item));
                files.AddRange(someTypeFiles);
                this.worker.ReportProgress(-1);
            }

            AnimatedGifEncoder gifEncoder = new AnimatedGifEncoder();
            string gifFullname = Path.Combine(arg.saveAsGifInDirectory, arg.gifFileName);
            gifEncoder.Start(gifFullname);

            //每帧播放时间
            gifEncoder.SetDelay(arg.frameDelay);

            //-1：不重复，0：重复
            gifEncoder.SetRepeat(arg.repeat ? 0 : -1);
            for (int i = 0, count = files.Count; i < count; i++)
            {
                gifEncoder.AddFrame(Image.FromFile(files[i]));
                this.worker.ReportProgress(i, new UserState(count));
            }
            gifEncoder.Finish();
        }

        class UserState
        {
            public int count;
            public UserState(int count)
            {
                // TODO: Complete member initialization
                this.count = count;
            }
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == -1)
            {
                if (this.prgBar.Value == this.prgBar.Maximum)
                {
                    this.prgBar.Value = this.prgBar.Minimum;
                }
                else
                {
                    this.prgBar.Value = this.prgBar.Value + 1;
                }
            }
            else
            {
                this.prgBar.Value = this.prgBar.Minimum +
                    (int)((this.prgBar.Maximum - this.prgBar.Minimum) * (e.ProgressPercentage / (float)((e.UserState as UserState).count)));
            }
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
            }
            else if (e.Cancelled)
            {
                MessageBox.Show("Cancelled");
            }
            else
            {
            }

            this.btnStart.Text = "Start";
            this.prgBar.Visible = false;
        }
    }
}
