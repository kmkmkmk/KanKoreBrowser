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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "null";
            // 
            // TwitterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 84);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PINTextBox);
            this.Controls.Add(this.PINLogin);
            this.Controls.Add(this.BrowserLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TwitterLogin";
            this.Text = "TwitterLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowserLogin;
        private System.Windows.Forms.Button PINLogin;
        private System.Windows.Forms.TextBox PINTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}