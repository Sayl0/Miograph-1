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
    public partial class ActiveNPassiveMode : Form
    {
        bool flag = false;
        public ActiveNPassiveMode()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private void kneeAngleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stepBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void heelBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sockBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ankleAngleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ankleSettingsBox_Click(object sender, EventArgs e)
        {

        }

        private void kneeSettingsBox_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
