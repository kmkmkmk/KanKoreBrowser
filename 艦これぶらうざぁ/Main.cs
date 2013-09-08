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
            //LoadXML と Token一旦削除
            Settings.LoadFromXmlFile();
            Settings.Instance.tokenurl_s = "";
            Settings.SaveToXmlFile();
            //SWFLoad
            axShockwaveFlash1.LoadMovie(0, "http://125.6.189.7/kcs/mainD2.swf");
            //ClosingEvent
            this.FormClosing += new FormClosingEventHandler(Main_Closing);
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LoginFormShow
            Login f = new Login();
            f.ShowInTaskbar = false;
            f.ShowDialog(this);
            f.Dispose();
            //LoginForm閉じた後にxmlからToken取得
            axShockwaveFlash1.LoadMovie(0, Settings.Instance.tokenurl_s);
        }

        private void ScreenShotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //保存場所の有無をxmlに確認
            if (Settings.Instance.save_s != "")
            {
                //保存先が設定してあった場合SWFオブジェクトのみ撮影
                Bitmap img = new Bitmap(axShockwaveFlash1.Width, axShockwaveFlash1.Height);
                Graphics memg = Graphics.FromImage(img);
                IntPtr dc = memg.GetHdc();
                PrintWindow(axShockwaveFlash1.Handle, dc, 0);
                memg.ReleaseHdc(dc);
                memg.Dispose();
                //png形式で保存
                img.Save(Settings.Instance.save_s + "\\KanKore_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png", ImageFormat.Png);
            }
            else
            {
                //保存先未設定の場合
                MessageBox.Show("保存先が設定されていません。\n保存先を設定して下さい", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ScreenShotSaveToolStripMenuItem.PerformClick();
            }
        }

        private void ScreenShotSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //スクリーンショット保存先設定
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "保存先フォルダを指定してください。";
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                //xmlに記述 -> Settings.cs内参照
                Settings.Instance.save_s = fbd.SelectedPath;
                Settings.SaveToXmlFile();
            }
        }

        private void TwitterLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TwitterLoginFormShow
            TwitterLogin f = new TwitterLogin();
            f.ShowInTaskbar = false;
            f.ShowDialog(this);
            f.Dispose();
        }

        private void TwitterPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TwitterPostFormShow
            TwitterPost f = new TwitterPost();
            f.ShowInTaskbar = false;
            f.ShowDialog(this);
            f.Dispose();
        }

        private void TopShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //最前面表示
            if (TopShowToolStripMenuItem.Checked)
            {
                //無効
                TopShowToolStripMenuItem.Checked = false;
                TopMost = false;
            }
            else
            {
                //有効
                TopShowToolStripMenuItem.Checked = true;
                TopMost = true;
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //終了
            Close();
        }

        private void VersionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Assembly取得 and バージョン情報
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            System.Version ver = asm.GetName().Version;

            MessageBox.Show("艦これぶらうざぁ " + ver + "\nLicense Agreement (The MIT/X11 License)\nCopyright (c) 2013 k725.\nhttp://my.iesaba.com/", "ばーじょん", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //明示的にGC実行
            GC.Collect();
        }

        private void Main_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //終了確認
            if (MessageBox.Show("本当に終了しますか?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            //Token削除
            Settings.Instance.tokenurl_s = "";
            Settings.SaveToXmlFile();
        }
    }
}
