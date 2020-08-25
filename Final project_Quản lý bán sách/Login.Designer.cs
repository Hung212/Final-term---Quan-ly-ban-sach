namespace QLNhaSach
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
            this.lbClose = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chbRemeberMe = new System.Windows.Forms.CheckBox();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbNameCompany = new System.Windows.Forms.Label();
            this.picPasswordWarning = new System.Windows.Forms.PictureBox();
            this.picUsernameWarning = new System.Windows.Forms.PictureBox();
            this.picLoginImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsernameWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.BackColor = System.Drawing.Color.Transparent;
            this.lbClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbClose.ForeColor = System.Drawing.Color.IndianRed;
            this.lbClose.Location = new System.Drawing.Point(352, 9);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(20, 19);
            this.lbClose.TabIndex = 0;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitle.Location = new System.Drawing.Point(43, 271);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(290, 37);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Login to your account";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUsername.Location = new System.Drawing.Point(46, 318);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(80, 22);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPassword.Location = new System.Drawing.Point(46, 376);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(74, 22);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUsername.Location = new System.Drawing.Point(50, 343);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(283, 25);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword.Location = new System.Drawing.Point(50, 401);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(283, 25);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // chbRemeberMe
            // 
            this.chbRemeberMe.AutoSize = true;
            this.chbRemeberMe.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chbRemeberMe.Location = new System.Drawing.Point(50, 437);
            this.chbRemeberMe.Name = "chbRemeberMe";
            this.chbRemeberMe.Size = new System.Drawing.Size(113, 22);
            this.chbRemeberMe.TabIndex = 8;
            this.chbRemeberMe.Text = "Remember me";
            this.chbRemeberMe.UseVisualStyleBackColor = true;
            this.chbRemeberMe.CheckedChanged += new System.EventHandler(this.chbRemeberMe_CheckedChanged);
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbForgotPassword.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbForgotPassword.Location = new System.Drawing.Point(218, 438);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(115, 18);
            this.lbForgotPassword.TabIndex = 9;
            this.lbForgotPassword.Text = "Forgot password?";
            this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLogin.Location = new System.Drawing.Point(48, 478);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(285, 46);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbNameCompany
            // 
            this.lbNameCompany.AutoSize = true;
            this.lbNameCompany.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNameCompany.Location = new System.Drawing.Point(43, 28);
            this.lbNameCompany.Name = "lbNameCompany";
            this.lbNameCompany.Size = new System.Drawing.Size(283, 28);
            this.lbNameCompany.TabIndex = 7;
            this.lbNameCompany.Text = "Hệ thống cửa hàng bán sách";
            // 
            // picPasswordWarning
            // 
            this.picPasswordWarning.Location = new System.Drawing.Point(339, 401);
            this.picPasswordWarning.Name = "picPasswordWarning";
            this.picPasswordWarning.Size = new System.Drawing.Size(28, 25);
            this.picPasswordWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPasswordWarning.TabIndex = 12;
            this.picPasswordWarning.TabStop = false;
            // 
            // picUsernameWarning
            // 
            this.picUsernameWarning.Location = new System.Drawing.Point(339, 343);
            this.picUsernameWarning.Name = "picUsernameWarning";
            this.picUsernameWarning.Size = new System.Drawing.Size(28, 25);
            this.picUsernameWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsernameWarning.TabIndex = 11;
            this.picUsernameWarning.TabStop = false;
            // 
            // picLoginImage
            // 
            this.picLoginImage.Image = global::QLNhaSach.Properties.Resources.userpng;
            this.picLoginImage.ImageLocation = "";
            this.picLoginImage.Location = new System.Drawing.Point(95, 81);
            this.picLoginImage.Name = "picLoginImage";
            this.picLoginImage.Size = new System.Drawing.Size(189, 173);
            this.picLoginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoginImage.TabIndex = 1;
            this.picLoginImage.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 566);
            this.Controls.Add(this.picPasswordWarning);
            this.Controls.Add(this.picUsernameWarning);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbForgotPassword);
            this.Controls.Add(this.chbRemeberMe);
            this.Controls.Add(this.lbNameCompany);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.picLoginImage);
            this.Controls.Add(this.lbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsernameWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.PictureBox picLoginImage;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chbRemeberMe;
        private System.Windows.Forms.Label lbForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbNameCompany;
        private System.Windows.Forms.PictureBox picUsernameWarning;
        private System.Windows.Forms.PictureBox picPasswordWarning;
    }
}