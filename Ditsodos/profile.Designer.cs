namespace Ditsodos
{
    partial class Profile
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.winsNumberLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.loseLabel1 = new MetroFramework.Controls.MetroLabel();
            this.backDashboardProfileButton = new MetroFramework.Controls.MetroButton();
            this.metroTile1.SuspendLayout();
            this.metroTile2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Controls.Add(this.winsNumberLabel);
            this.metroTile1.Location = new System.Drawing.Point(41, 77);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(92, 79);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Wins";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile1.Click += new System.EventHandler(this.MetroTile1_Click);
            // 
            // winsNumberLabel
            // 
            this.winsNumberLabel.AutoSize = true;
            this.winsNumberLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.winsNumberLabel.Location = new System.Drawing.Point(33, 29);
            this.winsNumberLabel.Name = "winsNumberLabel";
            this.winsNumberLabel.Size = new System.Drawing.Size(21, 25);
            this.winsNumberLabel.TabIndex = 0;
            this.winsNumberLabel.Text = "0";
            // 
            // metroTile2
            // 
            this.metroTile2.Controls.Add(this.loseLabel1);
            this.metroTile2.Location = new System.Drawing.Point(159, 77);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(92, 79);
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Lose";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // loseLabel1
            // 
            this.loseLabel1.AutoSize = true;
            this.loseLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.loseLabel1.Location = new System.Drawing.Point(33, 29);
            this.loseLabel1.Name = "loseLabel1";
            this.loseLabel1.Size = new System.Drawing.Size(21, 25);
            this.loseLabel1.TabIndex = 0;
            this.loseLabel1.Text = "0";
            // 
            // backDashboardProfileButton
            // 
            this.backDashboardProfileButton.Location = new System.Drawing.Point(113, 211);
            this.backDashboardProfileButton.Name = "backDashboardProfileButton";
            this.backDashboardProfileButton.Size = new System.Drawing.Size(75, 23);
            this.backDashboardProfileButton.TabIndex = 4;
            this.backDashboardProfileButton.Text = "Back";
            this.backDashboardProfileButton.Click += new System.EventHandler(this.BackDashboardProfileButton_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 257);
            this.Controls.Add(this.backDashboardProfileButton);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            this.metroTile2.ResumeLayout(false);
            this.metroTile2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel winsNumberLabel;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroLabel loseLabel1;
        private MetroFramework.Controls.MetroButton backDashboardProfileButton;
    }
}