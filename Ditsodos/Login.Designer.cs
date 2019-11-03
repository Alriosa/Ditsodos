namespace Ditsodos
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
            this.usernameTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordLoginTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.usernameLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.createAccountLink = new MetroFramework.Controls.MetroLink();
            this.exitGame = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(64, 101);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(116, 23);
            this.usernameTxtBox.TabIndex = 0;
            // 
            // passwordLoginTxtBox
            // 
            this.passwordLoginTxtBox.Location = new System.Drawing.Point(64, 166);
            this.passwordLoginTxtBox.Name = "passwordLoginTxtBox";
            this.passwordLoginTxtBox.PasswordChar = '*';
            this.passwordLoginTxtBox.Size = new System.Drawing.Size(116, 23);
            this.passwordLoginTxtBox.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(64, 76);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(68, 19);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(64, 141);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 19);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(83, 203);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Log In";
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // createAccountLink
            // 
            this.createAccountLink.BackColor = System.Drawing.Color.Aqua;
            this.createAccountLink.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createAccountLink.Location = new System.Drawing.Point(64, 285);
            this.createAccountLink.Name = "createAccountLink";
            this.createAccountLink.Size = new System.Drawing.Size(116, 23);
            this.createAccountLink.TabIndex = 4;
            this.createAccountLink.Text = "Crear cuenta";
            this.createAccountLink.Click += new System.EventHandler(this.CreateAccountLink_Click);
            // 
            // exitGame
            // 
            this.exitGame.Location = new System.Drawing.Point(83, 232);
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(75, 23);
            this.exitGame.TabIndex = 5;
            this.exitGame.Text = "Exit Game";
            this.exitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 310);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.createAccountLink);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordLoginTxtBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox usernameTxtBox;
        private MetroFramework.Controls.MetroTextBox passwordLoginTxtBox;
        private MetroFramework.Controls.MetroLabel usernameLabel;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroLink createAccountLink;
        private MetroFramework.Controls.MetroButton exitGame;
    }
}

