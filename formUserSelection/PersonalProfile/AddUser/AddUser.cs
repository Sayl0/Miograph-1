using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miograph.formUserSelection.PersonalProfile.AddUser;

namespace Miograph
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var frm = new AnamnesisDiagnosis();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void textBoxSecondName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            
        }


        private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void textBoxSecondName_Leave(object sender, EventArgs e)
        {
         
        }

        private void textBoxSecondName_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
        
        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
        
        }

        private void textBoxMiddleName_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBoxMiddleName_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBoxUserHeight_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBoxUserHeight_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBoxUserWeight_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBoxUserWeight_Enter(object sender, EventArgs e)
        {
            
        }

        private void labelUserHeight_Click(object sender, EventArgs e)
        {

        }
    }
}
