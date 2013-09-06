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
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScreenShot = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.TopShow = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.あばうとToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginID = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.axShockwaveFlash1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.あばうとToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScreenShot,
            this.SaveFolder,
            this.TopShow,
            this.Exit});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // ScreenShot
            // 
            this.ScreenShot.Name = "ScreenShot";
            this.ScreenShot.Size = new System.Drawing.Size(218, 22);
            this.ScreenShot.Text = "スクリーンショット撮影";
            this.ScreenShot.Click += new System.EventHandler(this.スクリーンショット撮影ToolStripMenuItem_Click);
            // 
            // SaveFolder
            // 
            this.SaveFolder.Name = "SaveFolder";
            this.SaveFolder.Size = new System.Drawing.Size(218, 22);
            this.SaveFolder.Text = "スクリーンショット保存先";
            this.SaveFolder.Click += new System.EventHandler(this.スクリーンショット保存先ToolStripMenuItem_Click);
            // 
            // TopShow
            // 
            this.TopShow.Name = "TopShow";
            this.TopShow.Size = new System.Drawing.Size(218, 22);
            this.TopShow.Text = "最前面表示";
            this.TopShow.Click += new System.EventHandler(this.最前面表示ToolStripMenuItem_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(218, 22);
            this.Exit.Text = "終了";
            this.Exit.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // あばうとToolStripMenuItem
            // 
            this.あばうとToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version});
            this.あばうとToolStripMenuItem.Name = "あばうとToolStripMenuItem";
            this.あばうとToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.あばうとToolStripMenuItem.Text = "あばうと";
            // 
            // version
            // 
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(152, 22);
            this.version.Text = "ばーじょん";
            this.version.Click += new System.EventHandler(this.ばーじょんToolStripMenuItem_Click);
            // 
            // LoginID
            // 
            this.LoginID.Location = new System.Drawing.Point(484, 1);
            this.LoginID.Name = "LoginID";
            this.LoginID.Size = new System.Drawing.Size(239, 19);
            this.LoginID.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(724, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 20);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LoginID);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "艦これぶらうざぁ";
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TopShow;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem あばうとToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version;
        private System.Windows.Forms.ToolStripMenuItem ScreenShot;
        private System.Windows.Forms.ToolStripMenuItem SaveFolder;
        private System.Windows.Forms.TextBox LoginID;
        private System.Windows.Forms.Button Login;
    }
}

