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
            this.PictureSelect = new System.Windows.Forms.Button();
            this.Tweet = new System.Windows.Forms.Button();
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            this.HashTag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // TweetText
            // 
            this.TweetText.Location = new System.Drawing.Point(12, 12);
            this.TweetText.MaxLength = 110;
            this.TweetText.Multiline = true;
            this.TweetText.Name = "TweetText";
            this.TweetText.Size = new System.Drawing.Size(232, 56);
            this.TweetText.TabIndex = 0;
            // 
            // PictureSelect
            // 
            this.PictureSelect.Location = new System.Drawing.Point(146, 102);
            this.PictureSelect.Name = "PictureSelect";
            this.PictureSelect.Size = new System.Drawing.Size(98, 23);
            this.PictureSelect.TabIndex = 1;
            this.PictureSelect.Text = "画像選択";
            this.PictureSelect.UseVisualStyleBackColor = true;
            this.PictureSelect.Click += new System.EventHandler(this.PictureSelect_Click);
            // 
            // Tweet
            // 
            this.Tweet.Location = new System.Drawing.Point(146, 73);
            this.Tweet.Name = "Tweet";
            this.Tweet.Size = new System.Drawing.Size(98, 23);
            this.Tweet.TabIndex = 2;
            this.Tweet.Text = "投稿";
            this.Tweet.UseVisualStyleBackColor = true;
            this.Tweet.Click += new System.EventHandler(this.Tweet_Click);
            // 
            // Thumbnail
            // 
            this.Thumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Thumbnail.Location = new System.Drawing.Point(12, 74);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(128, 80);
            this.Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Thumbnail.TabIndex = 3;
            this.Thumbnail.TabStop = false;
            // 
            // HashTag
            // 
            this.HashTag.AutoSize = true;
            this.HashTag.Location = new System.Drawing.Point(146, 137);
            this.HashTag.Name = "HashTag";
            this.HashTag.Size = new System.Drawing.Size(61, 16);
            this.HashTag.TabIndex = 4;
            this.HashTag.Text = "#艦これ";
            this.HashTag.UseVisualStyleBackColor = true;
            this.HashTag.CheckedChanged += new System.EventHandler(this.HashTag_CheckedChanged);
            // 
            // TwitterPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 166);
            this.Controls.Add(this.HashTag);
            this.Controls.Add(this.Thumbnail);
            this.Controls.Add(this.Tweet);
            this.Controls.Add(this.PictureSelect);
            this.Controls.Add(this.TweetText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TwitterPost";
            this.Text = "TwitterPost";
            this.Load += new System.EventHandler(this.TwitterPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TweetText;
        private System.Windows.Forms.Button PictureSelect;
        private System.Windows.Forms.Button Tweet;
        private System.Windows.Forms.PictureBox Thumbnail;
        private System.Windows.Forms.CheckBox HashTag;
    }
}