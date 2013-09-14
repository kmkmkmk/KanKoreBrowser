using System;
using System.Diagnostics;
using System.Windows.Forms;
using TweetSharp;

namespace 艦これぶらうざぁ
{
    public partial class TwitterLogin : Form
    {
        // TweetSharp関連の宣言
        TwitterService service = new TwitterService("AzW9Fa0ScA5qlVviNYaW1Q", "a5v5YlL9g9WvYWkvREf7JzUY5kf5F2cm2fHcr1AqSk");
        OAuthRequestToken requestToken;
        OAuthAccessToken access;

        public TwitterLogin()
        {
            InitializeComponent();
            // xml読み込み
            Settings.LoadFromXmlFile();
        }

        private void BrowserLogin_Click(object sender, System.EventArgs e)
        {
            // ブラウザーを起動(OAuth認証)
            requestToken = service.GetRequestToken();
            Uri uri = service.GetAuthenticationUrl(requestToken);
            Process.Start(uri.ToString());
        }

        private void PINLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // PIN入力
                string verifier;
                verifier = PINTextBox.Text;
                access = service.GetAccessToken(requestToken, verifier);
                service.AuthenticateWith(access.Token, access.TokenSecret);
                // xmlにToken保存
                Settings.Instance.token_s = access.Token;
                Settings.Instance.select_s = access.TokenSecret;
                Settings.SaveToXmlFile();
                // 完了メッセージ
                MessageBox.Show("アカウントが設定されました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // 閉じる
                Close();
            }
            catch
            {
                // 例外発生時のメッセージ
                MessageBox.Show("入力したPINが間違っています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
