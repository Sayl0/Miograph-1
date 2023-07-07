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
        private DataAccess db = new DataAccess();
        private long id;

        public PersonalProfile(long id)
        {
            InitializeComponent();
            this.id = id;

            List<PatientCard> patientCards = db.DoctorsPatients(id);

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
