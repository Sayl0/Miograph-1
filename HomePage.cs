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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void QuickStart_Click(object sender, EventArgs e)
        {
            var myForm = new UserManual();
            myForm.Show();
        }

        private void UserSelection_Click(object sender, EventArgs e)
        {

        }

        private void UserManual_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
