using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ditsodos
{
    public partial class OnGame : MetroFramework.Forms.MetroForm
    {
        public OnGame()
        {
            InitializeComponent();
        }

        private void OnGame_Load(object sender, EventArgs e)
        {

        }

        private void MetroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {

        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void MetroLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void MetroUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
