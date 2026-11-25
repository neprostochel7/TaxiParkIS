namespace TaxiParkIS
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlCaptcha = new System.Windows.Forms.Panel();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.pnlCaptcha.SuspendLayout();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(60, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "ИС Таксопарка — Вход";
            // lblLogin
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(20, 60);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Text = "Логин:";
            // txtLogin
            this.txtLogin.Location = new System.Drawing.Point(100, 57);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(260, 25);
            this.txtLogin.TabIndex = 0;
            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 95);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Пароль:";
            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(100, 92);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(260, 25);
            this.txtPassword.TabIndex = 1;
            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(100, 130);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(260, 35);
            this.btnLogin.Text = "Войти";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // lblMessage
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMessage.Location = new System.Drawing.Point(20, 175);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Text = "";
            // pnlCaptcha
            this.pnlCaptcha.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlCaptcha.Location = new System.Drawing.Point(10, 195);
            this.pnlCaptcha.Name = "pnlCaptcha";
            this.pnlCaptcha.Size = new System.Drawing.Size(360, 180);
            this.pnlCaptcha.Visible = false;
            // btnShuffle
            this.btnShuffle.Location = new System.Drawing.Point(20, 140);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(120, 30);
            this.btnShuffle.Text = "Перемешать";
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            this.pnlCaptcha.Controls.Add(this.btnShuffle);
            // LoginForm
            this.ClientSize = new System.Drawing.Size(384, 390);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlCaptcha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация — ИС Таксопарка";
            this.pnlCaptcha.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlCaptcha;
        private System.Windows.Forms.Button btnShuffle;
    }
}
