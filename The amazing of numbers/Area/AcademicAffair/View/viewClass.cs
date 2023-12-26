using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class viewClass : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        User cur_user;
        public viewClass()
        {
            InitializeComponent();
        }
        public viewClass(User cur_user)
        {
            InitializeComponent();
            this.cur_user = cur_user;
            Academic_Affair aa = db.Academic_Affairs.Where(x => x.id == cur_user.id).FirstOrDefault();
           
        }

        private void viewClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBUniversityFullDataSet1.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.dBUniversityFullDataSet1.Class);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow info = dataGridView1.Rows[e.RowIndex]; 
                LectureRegisClass result = db.LectureRegisClasses.Where(x => x.class_id == info.Cells[1].Value.ToString()).FirstOrDefault();
                Lecture deepresult = db.Lectures.Where(x => x.id == result.id.ToString()).FirstOrDefault();
                ID.Text = result.id.ToString();
                username.Text = deepresult.name_.ToString();
                Department.Text = deepresult.department_id.ToString();
            }
            
        }
    }
}
