using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RetroED.Tools.RSVExtractor
{
    public partial class MainForm : DockContent
    {

        public RSDKv1.Video video;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SelRSVButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Retro Sonic Video files|*.rsv";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                video = new RSDKv1.Video(dlg.FileName);
            }
        }

        private void ExtractRSVButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "GIF|*.gif|PNG|*.png|Bitmap|*.bmp";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                System.Drawing.Imaging.ImageFormat format;

                switch(dlg.FilterIndex-1)
                {
                    case 0:
                    default:
                        format = System.Drawing.Imaging.ImageFormat.Gif;
                        break;
                    case 1:
                        format = System.Drawing.Imaging.ImageFormat.Png;
                        break;
                    case 2:
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                }

                if (ExportAllCB.Checked)
                {
                    string bruh = dlg.FileName.Replace(System.IO.Path.GetFileName(dlg.FileName), "");
                    for (int i = 0; i < video?.Frames.Count; i++)
                    {
                        video.Frames[i].Export(bruh + System.IO.Path.GetFileNameWithoutExtension(dlg.FileName) + (i + 1) + System.IO.Path.GetExtension(dlg.FileName), format);
                    }
                }
                else
                {
                    video.Frames[0].Export(dlg.FileName, format);
                }

            }
        }
    }
}
