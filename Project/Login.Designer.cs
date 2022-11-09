namespace Project
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
            this.loginLabelUsername = new System.Windows.Forms.Label();
            this.tbLoginUsername = new System.Windows.Forms.TextBox();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.loginLabelPassword = new System.Windows.Forms.Label();
            this.loginLabelLogin = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabelUsername
            // 
            this.loginLabelUsername.AutoSize = true;
            this.loginLabelUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelUsername.Location = new System.Drawing.Point(85, 89);
            this.loginLabelUsername.Name = "loginLabelUsername";
            this.loginLabelUsername.Size = new System.Drawing.Size(86, 19);
            this.loginLabelUsername.TabIndex = 0;
            this.loginLabelUsername.Text = "Username:";
            // 
            // tbLoginUsername
            // 
            this.tbLoginUsername.Location = new System.Drawing.Point(177, 89);
            this.tbLoginUsername.Name = "tbLoginUsername";
            this.tbLoginUsername.Size = new System.Drawing.Size(200, 20);
            this.tbLoginUsername.TabIndex = 1;
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Location = new System.Drawing.Point(177, 133);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(200, 20);
            this.tbLoginPassword.TabIndex = 3;
            this.tbLoginPassword.UseSystemPasswordChar = true;
            // 
            // loginLabelPassword
            // 
            this.loginLabelPassword.AutoSize = true;
            this.loginLabelPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelPassword.Location = new System.Drawing.Point(85, 133);
            this.loginLabelPassword.Name = "loginLabelPassword";
            this.loginLabelPassword.Size = new System.Drawing.Size(82, 19);
            this.loginLabelPassword.TabIndex = 2;
            this.loginLabelPassword.Text = "Password:";
            // 
            // loginLabelLogin
            // 
            this.loginLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelLogin.Location = new System.Drawing.Point(0, 0);
            this.loginLabelLogin.Name = "loginLabelLogin";
            this.loginLabelLogin.Size = new System.Drawing.Size(480, 50);
            this.loginLabelLogin.TabIndex = 5;
            this.loginLabelLogin.Text = "Login";
            this.loginLabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(167, 206);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(150, 30);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.loginLabelLogin);
            this.Controls.Add(this.tbLoginPassword);
            this.Controls.Add(this.loginLabelPassword);
            this.Controls.Add(this.tbLoginUsername);
            this.Controls.Add(this.loginLabelUsername);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabelUsername;
        private System.Windows.Forms.TextBox tbLoginUsername;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.Label loginLabelPassword;
        private System.Windows.Forms.Label loginLabelLogin;
        private System.Windows.Forms.Button buttonLogin;
    }
}

