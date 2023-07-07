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
using Miograph.formUserSelection.PersonalProfile.SelectUser;
using Miograph.formUserSelection.PersonalProfile.SelectUser.CourseParameters;
using Miograph.formUserSelection.PersonalProfile.SelectUser.GenerateExtract;
using Miograph.formUserSelection.PersonalProfile.SelectUser.GenerateExtract.TargetParameters;

namespace Miograph
{
    public partial class SelectUser : Form
    {
        public SelectUser()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectUser_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonEditMap_Click(object sender, EventArgs e)
        {
            var frm = new AddUser();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void buttonRunDiagnostics_Click(object sender, EventArgs e)
        {
            var frm = new RunDiagnostic();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void buttonGenerateStatement_Click(object sender, EventArgs e)
        {
            var frm = new Excerpt();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void buttonCourseParmeters_Click(object sender, EventArgs e)
        {
            var frm = new CourseParameters();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
