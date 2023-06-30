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
    public partial class RegistrationForm : Form
    {
        private DataAccess db = new DataAccess();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFullName.Text) && !string.IsNullOrEmpty(textBoxLogin.Text) && !string.IsNullOrEmpty(textBoxPassword.Text) && textBoxPassword.Text == textBoxPasswordConfirm.Text && (radioButtonDoctor.Checked || radioButtonOperator.Checked))
            {
                string Acc_type;
                if (radioButtonDoctor.Checked)
                {
                    Acc_type = "doctor";
                }
                else
                {
                    Acc_type = "operator";
                }

                User user = new User(0, textBoxFullName.Text, Acc_type, textBoxLogin.Text, textBoxPassword.Text);

                long id = db.RegistrEmployee(user);
                MessageBox.Show("Вы успешно зарегистрировались. Ваш id: " + id);
                var frm = new UserSelection();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDoctor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOperator_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
