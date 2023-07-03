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
    public partial class ActiveMode : Form
    {
        bool flag = false;
        public ActiveMode()
        {
            InitializeComponent();
        }

        private void angleBox_Click(object sender, EventArgs e)
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
    }
}
