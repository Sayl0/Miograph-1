using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miograph.formUserSelection.PersonalProfile.SelectUser.RunDiagnostics;

namespace Miograph.formUserSelection.PersonalProfile.SelectUser
{
    public partial class RunDiagnostic : Form
    {
        public RunDiagnostic()
        {
            InitializeComponent();
        }

        // Диагностика подвижности колена
        private void buttonKneeMobility_Click(object sender, EventArgs e)
        {
            var frm = new KneeMobility();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        // Диагностика подвижности стопы
        private void buttonFootMobility_Click(object sender, EventArgs e)
        {
            var frm = new FootMobility();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        // Диагностика силы мышц голеностопа
        private void buttonAnkleMuscleStrength_Click(object sender, EventArgs e)
        {
            var frm = new AnkleMuscleStrength();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        // Диагностика силы мышц бедра
        private void buttonHipMuscleStrength_Click(object sender, EventArgs e)
        {
            var frm = new HipMuscleStrength();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
