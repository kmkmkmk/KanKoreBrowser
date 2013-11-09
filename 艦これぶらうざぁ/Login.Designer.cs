using System.Windows.Forms;
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.GameLogout = new System.Windows.Forms.Button();
            this.GameLogin = new System.Windows.Forms.Button();
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID/Password入力後ページ内ログインボタンを押して下さい。";
            // 
            // GameLogout
            // 
            this.GameLogout.Location = new System.Drawing.Point(152, 260);
            this.GameLogout.Name = "GameLogout";
            this.GameLogout.Size = new System.Drawing.Size(64, 23);
            this.GameLogout.TabIndex = 4;
            this.GameLogout.Text = "ログアウト";
            this.GameLogout.UseVisualStyleBackColor = true;
            this.GameLogout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // GameLogin
            // 
            this.GameLogin.Location = new System.Drawing.Point(221, 260);
            this.GameLogin.Name = "GameLogin";
            this.GameLogin.Size = new System.Drawing.Size(91, 23);
            this.GameLogin.TabIndex = 5;
            this.GameLogin.Text = "ログインページ";
            this.GameLogin.UseVisualStyleBackColor = true;
            this.GameLogin.Click += new System.EventHandler(this.GameLogin_Click);
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Location = new System.Drawing.Point(12, 12);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(300, 230);
            this.geckoWebBrowser1.TabIndex = 6;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.geckoWebBrowser1);
            this.Controls.Add(this.GameLogin);
            this.Controls.Add(this.GameLogout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_Closing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GameLogout;
        private System.Windows.Forms.Button GameLogin;
        private Gecko.GeckoWebBrowser geckoWebBrowser1;
        private Button button1;
    }
}