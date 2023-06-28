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
    public partial class PersonalProfile : Form
    {
        public PersonalProfile()
        {
            InitializeComponent();
        }
      
        private void buttonExit_Click(object sender, EventArgs e)
        {
            var frm = new HomePage();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Close();
        }
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var frm = new AddUser();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void buttonSelectUser_Click(object sender, EventArgs e)
        {
            var frm = new SelectUser();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void PersonalProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
