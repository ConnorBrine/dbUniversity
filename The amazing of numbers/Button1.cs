
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers
{
    public partial class Button1 : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();

        public Button1()
        {
            InitializeComponent();
        }



        private void AllStudentBtn_CheckedChanged(object sender, EventArgs e)
        {
              var lst = (from user in db.Users 
                         select user).OrderBy(i => i.role_).ToList();
              dataGridView1.DataSource = lst;

      
        }

        private void LectureBtn_CheckedChanged(object sender, EventArgs e)
        {
            var lst = (from user in db.Users where user.role_ == "lecture" select user).OrderBy(i => i.role_).ToList();
            dataGridView1.DataSource = lst;
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.DefaultCellStyle.BackColor = Color.Pink;
        }
        private void AcademicBtn_CheckedChanged(object sender, EventArgs e)
        {
            var lst = (from user in db.Users where user.role_ == "academic affair" select user).OrderBy(i => i.role_).ToList();
            dataGridView1.DataSource = lst;
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.DefaultCellStyle.BackColor = Color.FromArgb(97, 252, 102);
        }
        private void StudentBtn_CheckedChanged(object sender, EventArgs e)
        {
            var lst = (from user in db.Users where user.role_ == "student" select user).OrderBy(i => i.role_).ToList();
            dataGridView1.DataSource = lst;
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.DefaultCellStyle.BackColor = Color.FromArgb(87, 185, 249);
        }

        private void AdminBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            var lst = (from user in db.Users where user.role_ == "admin" select user).OrderBy(i => i.role_).ToList();
            dataGridView1.DataSource = lst;
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.DefaultCellStyle.BackColor = Color.Yellow;
        }

        private void Button1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBUniversityDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dBUniversityDataSet.Users);

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
