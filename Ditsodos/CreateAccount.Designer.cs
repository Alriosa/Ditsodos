namespace Ditsodos
{
    partial class CreateAccount
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
            this.createAccountButton = new MetroFramework.Controls.MetroButton();
            this.cancelAccountButton = new MetroFramework.Controls.MetroButton();
            this.createUsernameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.createPasswordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.createConfirmPasswordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(215, 139);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(75, 23);
            this.createAccountButton.TabIndex = 0;
            this.createAccountButton.Text = "Accept";
            // 
            // cancelAccountButton
            // 
            this.cancelAccountButton.Location = new System.Drawing.Point(296, 139);
            this.cancelAccountButton.Name = "cancelAccountButton";
            this.cancelAccountButton.Size = new System.Drawing.Size(75, 23);
            this.cancelAccountButton.TabIndex = 1;
            this.cancelAccountButton.Text = "Cancel";
            // 
            // createUsernameTextbox
            // 
            this.createUsernameTextbox.Location = new System.Drawing.Point(23, 84);
            this.createUsernameTextbox.Name = "createUsernameTextbox";
            this.createUsernameTextbox.PasswordChar = '●';
            this.createUsernameTextbox.Size = new System.Drawing.Size(157, 23);
            this.createUsernameTextbox.TabIndex = 2;
            this.createUsernameTextbox.UseSystemPasswordChar = true;
            this.createUsernameTextbox.Click += new System.EventHandler(this.MetroTextBox1_Click);
            // 
            // createPasswordTextbox
            // 
            this.createPasswordTextbox.Location = new System.Drawing.Point(23, 139);
            this.createPasswordTextbox.Name = "createPasswordTextbox";
            this.createPasswordTextbox.PasswordChar = '●';
            this.createPasswordTextbox.Size = new System.Drawing.Size(157, 23);
            this.createPasswordTextbox.TabIndex = 3;
            this.createPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // createConfirmPasswordTextbox
            // 
            this.createConfirmPasswordTextbox.Location = new System.Drawing.Point(215, 84);
            this.createConfirmPasswordTextbox.Name = "createConfirmPasswordTextbox";
            this.createConfirmPasswordTextbox.PasswordChar = '●';
            this.createConfirmPasswordTextbox.Size = new System.Drawing.Size(157, 23);
            this.createConfirmPasswordTextbox.TabIndex = 4;
            this.createConfirmPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 62);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Username";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Password";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(215, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Confirm Password";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 214);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.createConfirmPasswordTextbox);
            this.Controls.Add(this.createPasswordTextbox);
            this.Controls.Add(this.createUsernameTextbox);
            this.Controls.Add(this.cancelAccountButton);
            this.Controls.Add(this.createAccountButton);
            this.Name = "CreateAccount";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton createAccountButton;
        private MetroFramework.Controls.MetroButton cancelAccountButton;
        private MetroFramework.Controls.MetroTextBox createUsernameTextbox;
        private MetroFramework.Controls.MetroTextBox createPasswordTextbox;
        private MetroFramework.Controls.MetroTextBox createConfirmPasswordTextbox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}