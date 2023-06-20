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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            /*textBoxSecondName.ForeColor = SystemColors.GrayText;
            textBoxSecondName.Text = "Фамилия";*/
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxSecondName_TextChanged(object sender, EventArgs e)
        {
            /*if (textBoxSecondName.Text.Length == 0)
            {
                textBoxSecondName.Text = "Фамилия";
                textBoxSecondName.ForeColor = Color.Gray;
            }*/
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
