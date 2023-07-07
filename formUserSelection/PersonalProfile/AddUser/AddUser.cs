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

            textBoxFirstName.Text = "Имя";
            textBoxFirstName.ForeColor = Color.Gray;
            textBoxMiddleName.Text = "Отчество";
            textBoxMiddleName.ForeColor = Color.Gray;
            textBoxSecondName.Text = "Фамилия";
            textBoxSecondName.ForeColor = Color.Gray;
            textBoxUserWeight.Text = "кг";
            textBoxUserWeight.ForeColor = Color.Gray;
            textBoxUserHeight.Text = "см";
            textBoxUserHeight.ForeColor = Color.Gray;

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
            if (textBoxSecondName.Text == "")
            {
                textBoxSecondName.Text = "Фамилия";
                textBoxSecondName.ForeColor = Color.Gray;

            }
        }

        private void textBoxSecondName_Enter(object sender, EventArgs e)
        {
            if (textBoxSecondName.Text == "Фамилия")
            {
                textBoxSecondName.Text = "";
                textBoxSecondName.ForeColor = Color.Black;

            }
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "")
            {
                textBoxFirstName.Text = "Имя";
                textBoxFirstName.ForeColor = Color.Gray;

            }
        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "Имя")
            {
                textBoxFirstName.Text = "";
                textBoxFirstName.ForeColor = Color.Black;

            }
        }

        private void textBoxMiddleName_Leave(object sender, EventArgs e)
        {
            if (textBoxMiddleName.Text == "")
            {
                textBoxMiddleName.Text = "Отчество";
                textBoxMiddleName.ForeColor = Color.Gray;

            }
        }

        private void textBoxMiddleName_Enter(object sender, EventArgs e)
        {
            if (textBoxMiddleName.Text == "Отчество")
            {
                textBoxMiddleName.Text = "";
                textBoxMiddleName.ForeColor = Color.Black;

            }
        }

        private void textBoxUserHeight_Leave(object sender, EventArgs e)
        {
            if (textBoxUserHeight.Text == "")
            {
                textBoxUserHeight.Text = "см";
                textBoxUserHeight.ForeColor = Color.Gray;

            }
        }

        private void textBoxUserHeight_Enter(object sender, EventArgs e)
        {
            if (textBoxUserHeight.Text == "см")
            {
                textBoxUserHeight.Text = "";
                textBoxUserHeight.ForeColor = Color.Black;

            }
        }

        private void textBoxUserWeight_Leave(object sender, EventArgs e)
        {
            if (textBoxUserWeight.Text == "")
            {
                textBoxUserWeight.Text = "кг";
                textBoxUserWeight.ForeColor = Color.Gray;

            }
        }

        private void textBoxUserWeight_Enter(object sender, EventArgs e)
        {
            if (textBoxUserWeight.Text == "кг")
            {
                textBoxUserWeight.Text = "";
                textBoxUserWeight.ForeColor = Color.Black;

            }
        }
    }
}
