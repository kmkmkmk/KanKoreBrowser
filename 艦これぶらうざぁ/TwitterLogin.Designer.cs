namespace 艦これぶらうざぁ
{
    partial class TwitterLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwitterLogin));
            this.BrowserLogin = new System.Windows.Forms.Button();
            this.PINLogin = new System.Windows.Forms.Button();
            this.PINTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BrowserLogin
            // 
            this.BrowserLogin.Location = new System.Drawing.Point(12, 12);
            this.BrowserLogin.Name = "BrowserLogin";
            this.BrowserLogin.Size = new System.Drawing.Size(171, 23);
            this.BrowserLogin.TabIndex = 0;
            this.BrowserLogin.Text = "ブラウザを起動して認証";
            this.BrowserLogin.UseVisualStyleBackColor = true;
            this.BrowserLogin.Click += new System.EventHandler(this.BrowserLogin_Click);
            // 
            // PINLogin
            // 
            this.PINLogin.Location = new System.Drawing.Point(108, 39);
            this.PINLogin.Name = "PINLogin";
            this.PINLogin.Size = new System.Drawing.Size(75, 23);
            this.PINLogin.TabIndex = 1;
            this.PINLogin.Text = "認証";
            this.PINLogin.UseVisualStyleBackColor = true;
            this.PINLogin.Click += new System.EventHandler(this.PINLogin_Click);
            // 
            // PINTextBox
            // 
            this.PINTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.PINTextBox.Location = new System.Drawing.Point(12, 41);
            this.PINTextBox.MaxLength = 10;
            this.PINTextBox.Name = "PINTextBox";
            this.PINTextBox.Size = new System.Drawing.Size(90, 19);
            this.PINTextBox.TabIndex = 2;
            // 
            // TwitterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 73);
            this.Controls.Add(this.PINTextBox);
            this.Controls.Add(this.PINLogin);
            this.Controls.Add(this.BrowserLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TwitterLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TwitterLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowserLogin;
        private System.Windows.Forms.Button PINLogin;
        private System.Windows.Forms.TextBox PINTextBox;
    }
}