using System;
using System.Windows.Forms;

namespace 艦これぶらうざぁ
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // タイマーのinterval
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer3.Interval = 3000;
            // xml読み込み
            Settings.LoadFromXmlFile();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // ping(dmm.com)
            try
            {
                System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
                System.Net.NetworkInformation.PingReply reply = p.Send("www.dmm.com");
                p.Dispose();
                geckoWebBrowser1.Navigate("https://www.dmm.com/my/-/login/=/path=Sg9VTQFXDFcXFl5bWlcKGExKUVdUXgFNEU0KSVMVR28MBQ0BUwJZBwxK/");

                // タイマー開始
                timer3.Start();
            }
            catch
            {
                // 例外発生時メッセージ
                MessageBox.Show("ネットワークに接続できません!!(www.dmm.com)", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            // タイマーストップ
            timer3.Stop();
            // 閉じる
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Javascript実行
            geckoWebBrowser1.Navigate("javascript:(function(){location.href=$(\"embed\").attr(\"src\")})();");
            // タイマースタート
            timer2.Start();
            // タイマーストップ
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // xmlに保存
            Settings.Instance.tokenurl_s = geckoWebBrowser1.Url.ToString();
            Settings.SaveToXmlFile();
            // タイマーストップ
            timer2.Stop();
            // 閉じる
            Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            // ログイン処理
            if (geckoWebBrowser1.Url.ToString() == "http://www.dmm.com/netgame/social/-/gadgets/=/app_id=854854/")
            {
                // Javascript実行
                geckoWebBrowser1.Navigate("javascript:(function(){location.href=$(\"iframe\").attr(\"src\")})();");
                // タイマースタート
                timer1.Start();
                // タイマー終了
                timer3.Stop();
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            // ログアウトURL
            geckoWebBrowser1.Navigate("http://www.dmm.com/my/-/login/logout/");            
        }

        private void GameLogin_Click(object sender, EventArgs e)
        {
            // 艦これゲームURL(未ログインの場合はログイン画面)
            geckoWebBrowser1.Navigate("https://www.dmm.com/my/-/login/=/path=Sg9VTQFXDFcXFl5bWlcKGExKUVdUXgFNEU0KSVMVR28MBQ0BUwJZBwxK/");
        }
    }
}
