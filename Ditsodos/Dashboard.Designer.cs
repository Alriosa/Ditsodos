namespace Ditsodos
{
    partial class Dashboard
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
            this.newGameButton = new MetroFramework.Controls.MetroButton();
            this.seeVictoryButton = new MetroFramework.Controls.MetroButton();
            this.dashboardExitButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(23, 75);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(239, 97);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "Play!";
            // 
            // seeVictoryButton
            // 
            this.seeVictoryButton.Location = new System.Drawing.Point(268, 75);
            this.seeVictoryButton.Name = "seeVictoryButton";
            this.seeVictoryButton.Size = new System.Drawing.Size(239, 97);
            this.seeVictoryButton.TabIndex = 1;
            this.seeVictoryButton.Text = "See your Victories";
            // 
            // dashboardExitButton
            // 
            this.dashboardExitButton.Location = new System.Drawing.Point(513, 75);
            this.dashboardExitButton.Name = "dashboardExitButton";
            this.dashboardExitButton.Size = new System.Drawing.Size(239, 97);
            this.dashboardExitButton.TabIndex = 2;
            this.dashboardExitButton.Text = "Exit";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 220);
            this.Controls.Add(this.dashboardExitButton);
            this.Controls.Add(this.seeVictoryButton);
            this.Controls.Add(this.newGameButton);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton newGameButton;
        private MetroFramework.Controls.MetroButton seeVictoryButton;
        private MetroFramework.Controls.MetroButton dashboardExitButton;
    }
}