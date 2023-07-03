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
    public partial class KneeMobility : Form
    {
        bool flag = false;

        public KneeMobility()
        {
            InitializeComponent();
        }

        private void KneeMobility_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Сгибание
        private void buttonFlexion_Click(object sender, EventArgs e)
        {

        }

        // Остановка
        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                buttonStop.Text = "Остаовка";
                flag = true;
            }
            else
            {
                buttonStop.Text = "Запуск";
                flag = false;
            }
        }

        // Разгибание
        private void buttonExtension_Click(object sender, EventArgs e)
        {

        }

        // Положение каретки
        private void timeBoxCarriage_TextChanged(object sender, EventArgs e)
        {

        }
        
        // Текущий угол
        private void labelCurrentAngle_Click(object sender, EventArgs e)
        {

        }
    }
}
