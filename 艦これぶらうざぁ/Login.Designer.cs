namespace 艦これぶらうざぁ
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.geckoWebBrowser1 = new Skybound.Gecko.GeckoWebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.CloseForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GameLogout = new System.Windows.Forms.Button();
            this.GameLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Location = new System.Drawing.Point(12, 12);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(481, 296);
            this.geckoWebBrowser1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(429, 314);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(64, 23);
            this.CloseForm.TabIndex = 2;
            this.CloseForm.Text = "閉じる";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID/Password入力後ログインボタンを押して下さい。\r\n自動で処理します";
            // 
            // GameLogout
            // 
            this.GameLogout.Location = new System.Drawing.Point(263, 314);
            this.GameLogout.Name = "GameLogout";
            this.GameLogout.Size = new System.Drawing.Size(64, 23);
            this.GameLogout.TabIndex = 4;
            this.GameLogout.Text = "ログアウト";
            this.GameLogout.UseVisualStyleBackColor = true;
            this.GameLogout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // GameLogin
            // 
            this.GameLogin.Location = new System.Drawing.Point(332, 314);
            this.GameLogin.Name = "GameLogin";
            this.GameLogin.Size = new System.Drawing.Size(91, 23);
            this.GameLogin.TabIndex = 5;
            this.GameLogin.Text = "ログインページ";
            this.GameLogin.UseVisualStyleBackColor = true;
            this.GameLogin.Click += new System.EventHandler(this.GameLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 349);
            this.ControlBox = false;
            this.Controls.Add(this.GameLogin);
            this.Controls.Add(this.GameLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.geckoWebBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Skybound.Gecko.GeckoWebBrowser geckoWebBrowser1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GameLogout;
        private System.Windows.Forms.Button GameLogin;
    }
}