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
    public partial class UserSelection : Form
    {
        public UserSelection()
        {
            InitializeComponent();
        }

        private void UserSelection_Load(object sender, EventArgs e)
        {
            DataAccess.InitializeDatabase();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var frm = new RegistrationForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            var frm = new PersonalProfile();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
