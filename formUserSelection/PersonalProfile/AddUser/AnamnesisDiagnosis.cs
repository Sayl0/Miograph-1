using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miograph.formUserSelection.PersonalProfile.AddUser
{
    public partial class AnamnesisDiagnosis : Form
    {
        public AnamnesisDiagnosis()
        {
            InitializeComponent();
        }

        
        private void AnamnesisDiagnosis_Load(object sender, EventArgs e)
        {

        }
        private void labelAnamnesisDiagnosis_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxAnamnesis_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDiagnosis_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxDiagnosis_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var frm = new PersonalData();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        
    }
}
