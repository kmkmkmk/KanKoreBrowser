using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using TweetSharp;

namespace 艦これぶらうざぁ
{
    public partial class TwitterPost : Form
    {
        TwitterService service = new TwitterService("AzW9Fa0ScA5qlVviNYaW1Q", "a5v5YlL9g9WvYWkvREf7JzUY5kf5F2cm2fHcr1AqSk");

        public TwitterPost()
        {
            InitializeComponent();
            // xml読み込み
            Settings.LoadFromXmlFile();
            // Tweetボタンを無効化
            Tweet.Enabled = false;
            // PictureBoxに""を
            Thumbnail.ImageLocation = "";

            // ハッシュタグの設定を読み込む
            if (Settings.Instance.hashtag_s == "True")
            {
                // 有効
                HashTag.Checked = true;
            }
            else
            {
                // 無効
                HashTag.Checked = false;
            }

            // Token等をセットする
            service.AuthenticateWith(Settings.Instance.token_s, Settings.Instance.select_s);
        }

        private void TweetPost_Click(object sender, EventArgs e)
        {
            Text = "TwitterPost - 投稿中…"; 
            try
            {
                // ハッシュタグ
                String hashtag = "";
                if (HashTag.Checked == true)
                {
                    // 有効
                    hashtag = " #艦これ";
                    Settings.Instance.hashtag_s = "True";
                }
                else if (HashTag.Checked == false)
                {
                    // 無効
                    hashtag = "";
                    Settings.Instance.hashtag_s = "False";
                }
                // xml保存
                Settings.SaveToXmlFile();

                // POST、画像つきPOST
                if (Thumbnail.ImageLocation != "")
                {
                    // 画像が選択されていた場合PictureBoxからパス取得
                    string photo = Thumbnail.ImageLocation;
                    var stream = new FileStream(photo, FileMode.Open);
                    SendTweetWithMediaOptions opt = new SendTweetWithMediaOptions();
                    opt.Status = TweetText.Text + hashtag;
                    opt.Images = new Dictionary<string, Stream> { { "image", stream } };
                    // イメージ付きでPOST
                    service.SendTweetWithMedia(opt);
                    // POST後空白
                    Thumbnail.ImageLocation = "";
                    TweetText.Text = "";
                    // 自動的に閉じる
                    Close();
                }
                else
                {
                    // テキストのみPOST
                    service.SendTweet(new SendTweetOptions { Status = TweetText.Text + hashtag });
                    // POST後空白
                    TweetText.Text = "";
                    // 自動的に閉じる
                    Close();
                }

            }
            catch (Exception)
            {
                // 例外発生時メッセージ
                MessageBox.Show("何らかのエラーが発生し投稿できませんでした", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LastPicSelect_Click(object sender, EventArgs e)
        {
            if (Settings.Instance.save_s != "")
            {
                string imgpath = Settings.Instance.save_s + "\\" + Settings.Instance.lastsave_s;

                if (System.IO.File.Exists(imgpath))
                {
                    // イメージボックスにセット
                    Thumbnail.ImageLocation = imgpath;
                }
                else
                {
                    // 見つからなかった場合
                    MessageBox.Show("最後に撮影されたスクリーンショットが見つかりませんでした","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                // 保存先が設定されていなかった場合
                MessageBox.Show("スクリーンショット撮影先が設定されていません","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void TweetText_TextChanged(object sender, EventArgs e)
        {
            // 文字数カウント
            int iLength = this.TweetText.TextLength;
            TweetCharacters.Text = iLength.ToString();

            // 文字数でボタンの有効/無効
            if (iLength.ToString() != "0")
            {
                // 有効
                Tweet.Enabled = true;
            }
            else if (iLength.ToString() == "0")
            {
                // 無効
                Tweet.Enabled = false;
            }
        }

        private void Thumbnail_Click(object sender, EventArgs e)
        {
            // 画像選択
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "画像ファイル(*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif";
            ofd.Title = "アップロードするファイルを選択してください";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // PictureBoxにイメージ設定
                Thumbnail.ImageLocation = ofd.FileName;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Ctrl + Enterで投稿可能
            if ((int)keyData == (int)Keys.Control + (int)Keys.Enter)
            {
                this.Tweet.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}