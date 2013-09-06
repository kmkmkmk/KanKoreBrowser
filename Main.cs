using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace 艦これぶらうざぁ
{


    public partial class Main : Form
    {

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private extern static bool PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);

        public Main()
        {
            InitializeComponent();
            
            String swfPath = "http://125.6.189.7/kcs/mainD2.swf";
            axShockwaveFlash1.LoadMovie(0, swfPath);
            Settings.LoadFromXmlFile();
        }

        private void スクリーンショット撮影ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Instance.save_s != "")
            {
                Bitmap img = new Bitmap(axShockwaveFlash1.Width, axShockwaveFlash1.Height);
                Graphics memg = Graphics.FromImage(img);
                IntPtr dc = memg.GetHdc();
                PrintWindow(axShockwaveFlash1.Handle, dc, 0);
                memg.ReleaseHdc(dc);
                memg.Dispose();
                string fmts = @"yyyy-MM-dd_HH-mm-ss";
                img.Save(Settings.Instance.save_s + "\\KanKore_" + DateTime.Now.ToString(fmts) + ".png", ImageFormat.Png);
            }
            else
            {
                MessageBox.Show("保存先が設定されていません。\n保存先を設定して下さい","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                スクリーンショット保存先ToolStripMenuItem.PerformClick();
            }
        }

        private void スクリーンショット保存先ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "保存先フォルダを指定してください。";
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                Settings.Instance.save_s = fbd.SelectedPath;
                Settings.SaveToXmlFile();
                Settings.LoadFromXmlFile();
            }
        }

        private void 最前面表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(最前面表示ToolStripMenuItem.Checked)
            {
                最前面表示ToolStripMenuItem.Checked = false;
                TopMost = false;
            }
            else
            {
                最前面表示ToolStripMenuItem.Checked = true;
                TopMost = true;
            }

        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ばーじょんToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("艦これぶらうざぁ verXX.XX\nLicense Agreement (The MIT/X11 License)\nCopyright (c) 2013 k725.\nhttp://my.iesaba.com/", "ばーじょん", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("何も入力されていません","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                 String swfPath = textBox1.Text;
                 axShockwaveFlash1.LoadMovie(0, swfPath);
            }
        }
    }
}