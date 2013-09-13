namespace 艦これぶらうざぁ
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScreecShotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TwitterPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScreenShotSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TwitterLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.UpdateCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginToolStripMenuItem,
            this.ScreecShotToolStripMenuItem,
            this.TwitterPostToolStripMenuItem,
            this.TopShowToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Image = global::艦これぶらうざぁ.Properties.Resources.Key;
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.LoginToolStripMenuItem.Text = "ログイン";
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // ScreecShotToolStripMenuItem
            // 
            this.ScreecShotToolStripMenuItem.Image = global::艦これぶらうざぁ.Properties.Resources.Save;
            this.ScreecShotToolStripMenuItem.Name = "ScreecShotToolStripMenuItem";
            this.ScreecShotToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.ScreecShotToolStripMenuItem.Text = "スクリーンショット撮影";
            this.ScreecShotToolStripMenuItem.Click += new System.EventHandler(this.ScreenShotToolStripMenuItem_Click);
            // 
            // TwitterPostToolStripMenuItem
            // 
            this.TwitterPostToolStripMenuItem.Image = global::艦これぶらうざぁ.Properties.Resources.Twitter;
            this.TwitterPostToolStripMenuItem.Name = "TwitterPostToolStripMenuItem";
            this.TwitterPostToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.TwitterPostToolStripMenuItem.Text = "Twitter投稿";
            this.TwitterPostToolStripMenuItem.Click += new System.EventHandler(this.TwitterPostToolStripMenuItem_Click);
            // 
            // TopShowToolStripMenuItem
            // 
            this.TopShowToolStripMenuItem.Name = "TopShowToolStripMenuItem";
            this.TopShowToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.TopShowToolStripMenuItem.Text = "最前面表示";
            this.TopShowToolStripMenuItem.Click += new System.EventHandler(this.TopShowToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Image = global::艦これぶらうざぁ.Properties.Resources.Exit;
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.CloseToolStripMenuItem.Text = "終了";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScreenShotSaveToolStripMenuItem,
            this.TwitterLoginToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // ScreenShotSaveToolStripMenuItem
            // 
            this.ScreenShotSaveToolStripMenuItem.Name = "ScreenShotSaveToolStripMenuItem";
            this.ScreenShotSaveToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ScreenShotSaveToolStripMenuItem.Text = "スクリーンショット保存先";
            this.ScreenShotSaveToolStripMenuItem.Click += new System.EventHandler(this.ScreenShotSaveToolStripMenuItem_Click);
            // 
            // TwitterLoginToolStripMenuItem
            // 
            this.TwitterLoginToolStripMenuItem.Name = "TwitterLoginToolStripMenuItem";
            this.TwitterLoginToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.TwitterLoginToolStripMenuItem.Text = "Twitterアカウント連携";
            this.TwitterLoginToolStripMenuItem.Click += new System.EventHandler(this.TwitterLoginToolStripMenuItem_Click);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VersionInfoToolStripMenuItem,
            this.UpdateCheckToolStripMenuItem,
            this.GCToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // VersionInfoToolStripMenuItem
            // 
            this.VersionInfoToolStripMenuItem.Image = global::艦これぶらうざぁ.Properties.Resources.Info;
            this.VersionInfoToolStripMenuItem.Name = "VersionInfoToolStripMenuItem";
            this.VersionInfoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.VersionInfoToolStripMenuItem.Text = "バージョン情報";
            this.VersionInfoToolStripMenuItem.Click += new System.EventHandler(this.VersionInfoToolStripMenuItem_Click);
            // 
            // GCToolStripMenuItem
            // 
            this.GCToolStripMenuItem.Name = "GCToolStripMenuItem";
            this.GCToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.GCToolStripMenuItem.Text = "GC";
            this.GCToolStripMenuItem.Click += new System.EventHandler(this.GCToolStripMenuItem_Click);
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(0, 24);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(800, 480);
            this.axShockwaveFlash1.TabIndex = 1;
            // 
            // UpdateCheckToolStripMenuItem
            // 
            this.UpdateCheckToolStripMenuItem.Image = global::艦これぶらうざぁ.Properties.Resources.Raise;
            this.UpdateCheckToolStripMenuItem.Name = "UpdateCheckToolStripMenuItem";
            this.UpdateCheckToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.UpdateCheckToolStripMenuItem.Text = "更新確認";
            this.UpdateCheckToolStripMenuItem.Click += new System.EventHandler(this.UpdateCheckToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "艦これぶらうざぁ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScreecShotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TopShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VersionInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GCToolStripMenuItem;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private System.Windows.Forms.ToolStripMenuItem TwitterPostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScreenShotSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TwitterLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateCheckToolStripMenuItem;
    }
}

