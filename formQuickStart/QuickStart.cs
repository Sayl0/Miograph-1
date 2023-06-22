using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miograph
{
    public partial class QuickStart : Form
    {
        public QuickStart()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void passiveButton_Click(object sender, EventArgs e)
        {
            var frm = new PassiveMode();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            Hide();
            frm.Show();
        }

        private void passiveAnkleButton_Click(object sender, EventArgs e)
        {
            var frm = new PassiveModeAnkle();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            Hide();
            frm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void activePassiveButton_Click(object sender, EventArgs e)
        {
            var frm = new ActiveNPassiveMode();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            Hide();
            frm.Show();
        }

        private void activeButton_Click(object sender, EventArgs e)
        {
            var frm = new ActiveMode();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            Hide();
            frm.Show();
        }
    }
}
