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
    public partial class PassiveModeAnkle : Form
    {
        bool flag = false;
        public PassiveModeAnkle()
        {
            InitializeComponent();
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
