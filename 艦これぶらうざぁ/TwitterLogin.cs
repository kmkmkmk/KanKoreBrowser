using System;
using System.Diagnostics;
using System.Windows.Forms;
using TweetSharp;

namespace 艦これぶらうざぁ
{
    public partial class TwitterLogin : Form
    {
        TwitterService service = new TwitterService("AzW9Fa0ScA5qlVviNYaW1Q", "a5v5YlL9g9WvYWkvREf7JzUY5kf5F2cm2fHcr1AqSk");
        OAuthRequestToken requestToken;
        OAuthAccessToken access;

        public TwitterLogin()
        {
            InitializeComponent();
            Settings.LoadFromXmlFile();
        }

        private void BrowserLogin_Click(object sender, System.EventArgs e)
        {
            //ブラウザーを起動(OAuth認証)
            requestToken = service.GetRequestToken();
            Uri uri = service.GetAuthenticationUrl(requestToken);
            Process.Start(uri.ToString());
        }

        private void PINLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //PINを入力後xmlに保存
                string verifier;
                verifier = PINTextBox.Text;
                access = service.GetAccessToken(requestToken, verifier);
                service.AuthenticateWith(access.Token, access.TokenSecret);
                Settings.Instance.token_s = access.Token;
                Settings.Instance.select_s = access.TokenSecret;
                Settings.SaveToXmlFile();
                MessageBox.Show("アカウントが設定されました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("入力したPINが間違っています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
