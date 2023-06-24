using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miograph.formUserSelection.PersonalProfile.SelectUser.RunDiagnostics
{
    public partial class FootMobility : Form
    {
        public FootMobility()
        {
            InitializeComponent();
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStarted_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Диапазон
        private void timeBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
