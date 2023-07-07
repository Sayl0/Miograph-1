using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miograph.formUserSelection.PersonalProfile.SelectUser.GenerateExtract.Session;
using Miograph.formUserSelection.PersonalProfile.SelectUser.GenerateExtract.TargetParameters;
using static System.Collections.Specialized.BitVector32;

namespace Miograph.formUserSelection.PersonalProfile.SelectUser.GenerateExtract
{
    public partial class Excerpt : Form
    {
        public Excerpt()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonInitialParameters_Click(object sender, EventArgs e)
        {
            var frm = new InitialParameters();
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
        }

        private void buttonTargetParameters_Click(object sender, EventArgs e)
        {
            var frm = new TargetParameters.TargetParameters();
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Session.Session();
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new Session.Session();
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new Session.Session();
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frm = new Session.Session();
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frm = new Session.Session();
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
        }
    }
}
