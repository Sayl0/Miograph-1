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

            PatientCard[] patientCards = new PatientCard[]
            {
                new PatientCard(0, 111, "Иванов", "Иван", "Иванович", "М", new DateTime(1980, 1, 1), 180, 80, new DateTime(2021, 1, 1)),
                new PatientCard(1, 112, "Петров", "Петр", "Петрович", "М", new DateTime(1985, 2, 2), 175, 75, new DateTime(2021, 2, 2)),
                new PatientCard(2, 113, "Сидорова", "Мария", "Ивановна", "Ж", new DateTime(1990, 3, 3), 170, 65, new DateTime(2021, 3, 3))
            };

           
            dataGridView1.DataSource = patientCards;

            // Отображение элемента управления DataGridView на форме
            this.Controls.Add(dataGridView1);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
