using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miograph.formUserSelection.PersonalProfile.SelectUser.RunDiagnostics;

namespace Miograph.formUserSelection.PersonalProfile.AddUser
{
    public partial class PersonalData : Form
    {
        public PersonalData()
        {
            InitializeComponent();

            textBoxKneeMobilityL.Text = " град";
            textBoxKneeMobilityL.ForeColor = Color.Gray;

            textBoxKneeMobilityR.Text = " град";
            textBoxKneeMobilityR.ForeColor = Color.Gray;

            textBoxFootMobilityL.Text = " град";
            textBoxFootMobilityL.ForeColor = Color.Gray;

            textBoxFootMobilityR.Text = " град";
            textBoxFootMobilityR.ForeColor =Color.Gray;

            textBoxHipGirthL.Text = " см";
            textBoxHipGirthL.ForeColor = Color.Gray;

            textBoxHipGirthR.Text = " см";
            textBoxHipGirthR.ForeColor = Color.Gray;
            

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        // Обхват бедра (см): Левая нога
        private void textBoxHipGirthL_TextChanged(object sender, EventArgs e)
        {

        }

        // Сила мышц бедра (баллы): Левая нога
        private void radioButtonHip1L_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonHip2L_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonHip3L_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonHip4L_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonHip5L_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// Сила мышц бедра (баллы) Левая нога End

        // Сила мышщ голени (баллы): Левая нога
        private void radioButtonTibia1L_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTibia2L_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTibia3L_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTibia4L_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTibia5L_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// Сила мышщ голени (баллы) Левая нога End

        // Подвижность колена (град): Левая нога
        private void textBoxKneeMobilityL_TextChanged(object sender, EventArgs e)
        {

        }

        // Подвижность стопы (град): Левая нога
        private void textBoxFootMobilityL_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxHipGirthL_Leave(object sender, EventArgs e)
        {
            if (textBoxHipGirthL.Text == "")
            {
                textBoxHipGirthL.Text = " см";
                textBoxHipGirthL.ForeColor = Color.Gray;

            }
        }

        private void textBoxHipGirthL_Enter(object sender, EventArgs e)
        {
            if (textBoxHipGirthL.Text == " см")
            {
                textBoxHipGirthL.Text = "";
                textBoxHipGirthL.ForeColor = Color.Gray;

            }
        }

        private void textBoxKneeMobilityL_Leave(object sender, EventArgs e)
        {
            if (textBoxKneeMobilityL.Text == "")
            {
                textBoxKneeMobilityL.Text = " град";
                textBoxKneeMobilityL.ForeColor = Color.Gray;

            }
        }

        private void textBoxKneeMobilityL_Enter(object sender, EventArgs e)
        {
            if (textBoxKneeMobilityL.Text == " град")
            {
                textBoxKneeMobilityL.Text = "";
                textBoxKneeMobilityL.ForeColor = Color.Gray;

            }
        }

        private void textBoxFootMobilityL_Leave(object sender, EventArgs e)
        {
            if (textBoxFootMobilityL.Text == "")
            {
                textBoxFootMobilityL.Text = " град";
                textBoxFootMobilityL.ForeColor = Color.Gray;

            }
        }

        private void textBoxFootMobilityL_Enter(object sender, EventArgs e)
        {
            if (textBoxFootMobilityL.Text == " град")
            {
                textBoxFootMobilityL.Text = "";
                textBoxFootMobilityL.ForeColor = Color.Gray;

            }
        }

        // Обхват бедра (см): Правая нога
        private void textBoxHipGirthR_TextChanged(object sender, EventArgs e)
        {

        }

        // Сила мышц бедра (баллы): Правая нога
        private void radioButtonHip1R_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonHip2R_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonHip3R_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonHip4R_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonHip5R_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// Сила мышц бедра (баллы) Правая нога End

        // Сила мышщ голени (баллы): Правая нога
        private void radioButtonTibia1R_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTibia2R_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTibia3R_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTibia4R_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTibia5R_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// Сила мышщ голени (баллы) Правая нога End

        // Подвижность колена (град): Правая нога
        private void textBoxKneeMobilityR_TextChanged(object sender, EventArgs e)
        {

        }

        // Подвижность стопы (град): Правая нога
        private void textBoxFootMobilityR_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHipGirthR_Leave(object sender, EventArgs e)
        {
            if (textBoxHipGirthR.Text == "")
            {
                textBoxHipGirthR.Text = " см";
                textBoxHipGirthR.ForeColor = Color.Gray;

            }
        }

        private void textBoxHipGirthR_Enter(object sender, EventArgs e)
        {
            if (textBoxHipGirthR.Text == " см")
            {
                textBoxHipGirthR.Text = "";
                textBoxHipGirthR.ForeColor = Color.Gray;

            }
        }

        private void textBoxKneeMobilityR_Leave(object sender, EventArgs e)
        {
            if (textBoxKneeMobilityR.Text == "")
            {
                textBoxKneeMobilityR.Text = " град";
                textBoxKneeMobilityR.ForeColor = Color.Gray;

            }
        }

        private void textBoxKneeMobilityR_Enter(object sender, EventArgs e)
        {
            if (textBoxKneeMobilityR.Text == " град")
            {
                textBoxKneeMobilityR.Text = "";
                textBoxKneeMobilityR.ForeColor = Color.Gray;

            }
        }

        private void textBoxFootMobilityR_Leave(object sender, EventArgs e)
        {
            if (textBoxKneeMobilityR.Text == "")
            {
                textBoxFootMobilityR.Text = " град";
                textBoxFootMobilityR.ForeColor = Color.Gray;

            }
        }

        private void textBoxFootMobilityR_Enter(object sender, EventArgs e)
        {
            if (textBoxFootMobilityR.Text == " град")
            {
                textBoxKneeMobilityR.Text = "";
                textBoxKneeMobilityR.ForeColor = Color.Gray;

            }
        }
    }
}
