using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;


namespace 艦これぶらうざぁ
{
    public partial class Main : Form
    {
        #region WindowsAPI(スクリーンショット撮影)
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private extern static bool PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);
        #endregion

        #region WindowsAPI(フォーム比率固定)
        // 比率(14.5:9)
        // Windowの比率に合わせるのも問題ありだし色々検討
        const double fixedRate = (double)14.5 / 9;
        const int WM_SIZING = 0x214;
        const int WMSZ_LEFT = 1;
        const int WMSZ_RIGHT = 2;
        const int WMSZ_TOP = 3;
        const int WMSZ_TOPLEFT = 4;
        const int WMSZ_TOPRIGHT = 5;
        const int WMSZ_BOTTOM = 6;
        const int WMSZ_BOTTOMLEFT = 7;
        const int WMSZ_BOTTOMRIGHT = 8;
        [StructLayout(LayoutKind.Sequential)]
        struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_SIZING:
                    RECT r = (RECT)Marshal.PtrToStructure(m.LParam, typeof(RECT));
                    int w = r.right - r.left - (Size.Width - ClientSize.Width);
                    int h = r.bottom - r.top - (Size.Height - ClientSize.Height);
                    int dw = (int)(h * fixedRate + 0.5) - w;
                    int dh = (int)(w / fixedRate + 0.5) - h;
                    switch (m.WParam.ToInt32())
                    {
                        case WMSZ_TOP:
                        case WMSZ_BOTTOM:
                            r.right += dw;
                            break;
                        case WMSZ_LEFT:
                        case WMSZ_RIGHT:
                            r.bottom += dh;
                            break;
                        case WMSZ_TOPLEFT:
                            if (dw > 0) r.left -= dw;
                            else r.top -= dh;
                            break;
                        case WMSZ_TOPRIGHT:
                            if (dw > 0) r.right += dw;
                            else r.top -= dh;
                            break;
                        case WMSZ_BOTTOMLEFT:
                            if (dw > 0) r.left -= dw;
                            else r.bottom += dh;
                            break;
                        case WMSZ_BOTTOMRIGHT:
                            if (dw > 0) r.right += dw;
                            else r.bottom += dh;
                            break;
                    }
                    Marshal.StructureToPtr(r, m.LParam, false);
                    goto default;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion

        public Main()
        {
            InitializeComponent();
            // xml読み込み
            Settings.LoadFromXmlFile();
            // TokenURL削除
            Settings.Instance.tokenurl_s = "";
            // xml保存
            Settings.SaveToXmlFile();
            // SWF読み込み
            axShockwaveFlash1.LoadMovie(0, "http://125.6.189.7/kcs/mainD2.swf");
        }
        
        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ログインフォーム表示
            Login f = new Login();
            f.ShowInTaskbar = false;
            f.ShowDialog(this);
            f.Dispose();

            // ログインフォーム閉じた後にTokenURL取得
            if (Settings.Instance.tokenurl_s != "")
            {
                // SWFオブジェクトにURLを適応
                axShockwaveFlash1.LoadMovie(0, Settings.Instance.tokenurl_s);
            }
        }

        private void ScreenShotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 保存場所の有無をxmlに確認
            if (Settings.Instance.save_s != "")
            {
                // 保存先が設定してあった場合SWFオブジェクトのみ撮影
                Bitmap img = new Bitmap(axShockwaveFlash1.Width, axShockwaveFlash1.Height);
                Graphics memg = Graphics.FromImage(img);
                IntPtr dc = memg.GetHdc();
                PrintWindow(axShockwaveFlash1.Handle, dc, 0);
                memg.ReleaseHdc(dc);
                memg.Dispose();
                // png形式で保存
                string now = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                img.Save(Settings.Instance.save_s + "\\KanKore_" + now + ".png", ImageFormat.Png);
                // xmlにファイル名を記録
                Settings.Instance.lastsave_s = "KanKore_" + now + ".png";
                Settings.SaveToXmlFile();
            }
            else
            {
                // 保存先未設定の場合
                MessageBox.Show("保存先が設定されていません。\n保存先を設定して下さい", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ScreenShotSaveToolStripMenuItem.PerformClick();
            }
        }

        private void TwitterPostToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            // アカウントが設定済みか簡易確認
            if (Settings.Instance.token_s != "" && Settings.Instance.select_s != "")
            {
                // Twitter投稿フォーム表示
                TwitterPost f = new TwitterPost();
                f.ShowInTaskbar = false;
                f.ShowDialog(this);
                f.Dispose();
            }
            else
            {
                // 設定済みでなければ警告を出した後にClose
                MessageBox.Show("Twitterアカウントが設定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScreenShotandTweetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 保存場所、トークンの有無をxmlに確認
            if (Settings.Instance.save_s != ""　&& Settings.Instance.select_s !="" && Settings.Instance.token_s != "")
            {
                // 保存先が設定してあった場合SWFオブジェクトのみ撮影
                Bitmap img = new Bitmap(axShockwaveFlash1.Width, axShockwaveFlash1.Height);
                Graphics memg = Graphics.FromImage(img);
                IntPtr dc = memg.GetHdc();
                PrintWindow(axShockwaveFlash1.Handle, dc, 0);
                memg.ReleaseHdc(dc);
                memg.Dispose();

                // png形式で保存
                string now = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                img.Save(Settings.Instance.save_s + "\\KanKore_" + now + ".png", ImageFormat.Png);

                // xmlにファイル名を記録
                Settings.Instance.lastsave_s = "KanKore_" + now + ".png";
                Settings.SaveToXmlFile();
                
                // Twitter投稿フォーム表示
                TwitterPost f = new TwitterPost();
                f.ShowInTaskbar = false;
                f.ShowDialog(this);
                f.Dispose();
            }
            else if (Settings.Instance.save_s == "" && Settings.Instance.select_s == "" && Settings.Instance.token_s == "")
            {
                // 保存先、アカウント未設定の場合
                MessageBox.Show("Twitterアカウントと保存先が設定されていません。\n保存先を設定して下さい", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ScreenShotSaveToolStripMenuItem.PerformClick();
                TwitterLoginToolStripMenuItem.PerformClick();
            }
            else if (Settings.Instance.save_s != "" && (Settings.Instance.select_s == ""||
                                                        Settings.Instance.token_s == ""))
            {
                // アカウント未設定の場合
                MessageBox.Show("Twitterアカウントが設定されていません。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TwitterLoginToolStripMenuItem.PerformClick();
            }
            else if (Settings.Instance.save_s == "" && Settings.Instance.select_s != "" && Settings.Instance.token_s != "")
            {
                // 保存先未設定の場合
                MessageBox.Show("保存先が設定されていません。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TwitterLoginToolStripMenuItem.PerformClick();
            }
        }

        private void TopShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 最前面表示
            if (TopShowToolStripMenuItem.Checked)
            {
                // 無効
                TopShowToolStripMenuItem.Checked = false;
                TopMost = false;
            }
            else
            {
                // 有効
                TopShowToolStripMenuItem.Checked = true;
                TopMost = true;
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 終了
            Close();
        }

        private void ScreenShotSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // スクリーンショット保存先設定
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "保存先フォルダを指定してください。";
            
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                // xmlに設定保存
                Settings.Instance.save_s = fbd.SelectedPath;
                Settings.SaveToXmlFile();
            }

            fbd.Dispose();
        }

        private void TwitterLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Twitterログインフォーム表示
            TwitterLogin f = new TwitterLogin();
            f.ShowInTaskbar = false;
            f.ShowDialog(this);
            f.Dispose();
        }

        private void VersionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Assembly取得
            Assembly asm = Assembly.GetExecutingAssembly();
            Version ver = asm.GetName().Version;

            // メモリ使用量取得
            Process currentProcess = Process.GetCurrentProcess();
            currentProcess.Refresh();
            
            // メッセージボックス表示
            MessageBox.Show("艦これぶらうざぁ " + ver + "\nLicense Agreement (The MIT/X11 License)\nCopyright (c) 2013 k725.\nhttp://my.iesaba.com/","ばーじょん - UsingMemory" + (currentProcess.WorkingSet64 / 1048576) + "MB", MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            // 破棄
            currentProcess.Dispose();            
        }

        private void GCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 明示的にGC実行
            // アクセス不可能なオブジェクトを除去
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);

            // ファイナライゼーションが終わるまでスレッド待機
            GC.WaitForPendingFinalizers();

            // ファイナライズされたばかりのオブジェクトに関連するメモリを開放
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
        }

        private void UpdateCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // アップデートフォーム表示
            Update f = new Update();
            f.ShowInTaskbar = false;
            f.ShowDialog(this);
            f.Dispose();
        }

        private void Main_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // 終了確認
            if (MessageBox.Show("本当に終了しますか?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

            // Token削除
            Settings.Instance.tokenurl_s = "";
            Settings.SaveToXmlFile();
        }
    }
}
