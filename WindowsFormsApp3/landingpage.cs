using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class landingpage : Form
    {
        public landingpage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProceedToLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform lf = new loginform();
            lf.Show();
        }

        private void ProceedTOLoginButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            loginform lf = new loginform();
            lf.Closed += (s, args) => this.Close();
            lf.Show();
        }
    }
}
