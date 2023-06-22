using Miograph.formQuickStart.PassiveMode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miograph
{
    public partial class PassiveMode : Form
    {
        bool flag = false;
        public PassiveMode()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsBox_Click(object sender, EventArgs e)
        {
            var frm = new PassiveModeSettings();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.WindowsDefaultLocation;
            frm.FormClosing += delegate { this.Show(); };
            Hide();
            frm.Show();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                startButton.Text = "Пауза";
                flag = true;
            }
            else
            {
                startButton.Text = "Снять с паузы";
                flag = false;
            }
        }

        private void angleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void speedBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stepBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void modeText_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
