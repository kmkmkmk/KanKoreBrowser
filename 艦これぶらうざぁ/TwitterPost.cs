using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TweetSharp;

namespace 艦これぶらうざぁ
{
    public partial class TwitterPost : Form
    {
        TwitterService service = new TwitterService("AzW9Fa0ScA5qlVviNYaW1Q", "a5v5YlL9g9WvYWkvREf7JzUY5kf5F2cm2fHcr1AqSk");
        //変数宣言
        String imagepath = "";

        public TwitterPost()
        {
            InitializeComponent();
            //xml読み込み
            Settings.LoadFromXmlFile();
        }

        private void TwitterPost_Load(object sender, EventArgs e)
        {
            //アカウントが設定済みか簡易確認
            if (Settings.Instance.token_s != "" && Settings.Instance.select_s != "")
            {
                //設定済みならばToken等をセットする
                service.AuthenticateWith(Settings.Instance.token_s, Settings.Instance.select_s);
            }
            else
            {
                //設定済みでなければ警告を出した後にClose
                MessageBox.Show("Twitterアカウントが設定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            if (Settings.Instance.hashtag_s == "True")
            {
                HashTag.Checked = true;
            }
            else
            {
                HashTag.Checked = false;
            }
        }

        private void Tweet_Click(object sender, EventArgs e)
        {
            if (TweetText.Text != "")
            {
                //ハッシュタグ
                String hashtag = "";
                if (HashTag.Checked == true)
                {
                    hashtag = " #艦これ";
                }
                else if (HashTag.Checked == false)
                {
                    hashtag = "";
                }

                //POST、画像つきPOST 選択されていなければエラー
                if (imagepath != "")
                {
                    string photo = imagepath;
                    var stream = new FileStream(photo, FileMode.Open);
                    SendTweetWithMediaOptions opt = new SendTweetWithMediaOptions();
                    opt.Status = TweetText.Text + hashtag;
                    opt.Images = new Dictionary<string, Stream> { { "image", stream } };
                    service.SendTweetWithMedia(opt);
                    TweetText.Text = "";
                    Thumbnail.ImageLocation = "";
                }
                else
                {
                    service.SendTweet(new SendTweetOptions { Status = TweetText.Text + hashtag });
                    TweetText.Text = "";
                }

            }
        }

        private void HashTag_CheckedChanged(object sender, EventArgs e)
        {
            //最前面表示
            if (HashTag.Checked)
            {
                //無効
                Settings.Instance.hashtag_s = "True";
            }
            else
            {
                //有効
                Settings.Instance.hashtag_s = "False";
            }
            Settings.SaveToXmlFile();
        }

        private void TweetText_TextChanged(object sender, EventArgs e)
        {
            //文字数カウント
            int iLength = this.TweetText.TextLength;
            TweetCharacters.Text = iLength.ToString();
        }

        private void Thumbnail_Click(object sender, EventArgs e)
        {
            //画像選択
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "画像ファイル(*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif";
            ofd.Title = "アップロードするファイルを選択してください";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(ofd.FileName);
                imagepath = ofd.FileName;
                Thumbnail.ImageLocation = ofd.FileName;
            }
        }
    }
}
