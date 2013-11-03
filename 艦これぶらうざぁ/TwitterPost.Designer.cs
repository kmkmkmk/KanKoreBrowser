namespace 艦これぶらうざぁ
{
    partial class TwitterPost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwitterPost));
            this.TweetText = new System.Windows.Forms.TextBox();
            this.Tweet = new System.Windows.Forms.Button();
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            this.HashTag = new System.Windows.Forms.CheckBox();
            this.TweetCharacters = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LastPicSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // TweetText
            // 
            this.TweetText.Location = new System.Drawing.Point(12, 11);
            this.TweetText.MaxLength = 110;
            this.TweetText.Multiline = true;
            this.TweetText.Name = "TweetText";
            this.TweetText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TweetText.Size = new System.Drawing.Size(198, 74);
            this.TweetText.TabIndex = 0;
            this.TweetText.TextChanged += new System.EventHandler(this.TweetText_TextChanged);
            // 
            // Tweet
            // 
            this.Tweet.Location = new System.Drawing.Point(98, 118);
            this.Tweet.Name = "Tweet";
            this.Tweet.Size = new System.Drawing.Size(112, 23);
            this.Tweet.TabIndex = 2;
            this.Tweet.Text = "投稿(Ctrl+Enter)";
            this.Tweet.UseVisualStyleBackColor = true;
            this.Tweet.Click += new System.EventHandler(this.TweetPost_Click);
            // 
            // Thumbnail
            // 
            this.Thumbnail.BackColor = System.Drawing.Color.Transparent;
            this.Thumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Thumbnail.Location = new System.Drawing.Point(218, 26);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(189, 115);
            this.Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Thumbnail.TabIndex = 3;
            this.Thumbnail.TabStop = false;
            this.Thumbnail.Click += new System.EventHandler(this.Thumbnail_Click);
            // 
            // HashTag
            // 
            this.HashTag.AutoSize = true;
            this.HashTag.Location = new System.Drawing.Point(12, 95);
            this.HashTag.Name = "HashTag";
            this.HashTag.Size = new System.Drawing.Size(61, 16);
            this.HashTag.TabIndex = 4;
            this.HashTag.Text = "#艦これ";
            this.HashTag.UseVisualStyleBackColor = true;
            // 
            // TweetCharacters
            // 
            this.TweetCharacters.AutoSize = true;
            this.TweetCharacters.BackColor = System.Drawing.Color.White;
            this.TweetCharacters.Location = new System.Drawing.Point(190, 69);
            this.TweetCharacters.Name = "TweetCharacters";
            this.TweetCharacters.Size = new System.Drawing.Size(17, 12);
            this.TweetCharacters.TabIndex = 5;
            this.TweetCharacters.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "ボックスをクリックして画像を追加できます";
            // 
            // LastPicSelect
            // 
            this.LastPicSelect.Location = new System.Drawing.Point(98, 91);
            this.LastPicSelect.Name = "LastPicSelect";
            this.LastPicSelect.Size = new System.Drawing.Size(112, 23);
            this.LastPicSelect.TabIndex = 7;
            this.LastPicSelect.Text = "最新の画像を選択";
            this.LastPicSelect.UseVisualStyleBackColor = true;
            this.LastPicSelect.Click += new System.EventHandler(this.LastPicSelect_Click);
            // 
            // TwitterPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 148);
            this.Controls.Add(this.LastPicSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Thumbnail);
            this.Controls.Add(this.TweetCharacters);
            this.Controls.Add(this.HashTag);
            this.Controls.Add(this.Tweet);
            this.Controls.Add(this.TweetText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TwitterPost";
            this.Text = "TwitterPost";
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TweetText;
        private System.Windows.Forms.Button Tweet;
        private System.Windows.Forms.PictureBox Thumbnail;
        private System.Windows.Forms.CheckBox HashTag;
        private System.Windows.Forms.Label TweetCharacters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LastPicSelect;
    }
}