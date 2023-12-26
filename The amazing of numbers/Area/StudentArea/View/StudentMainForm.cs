using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.StudentArea.View
{
    public partial class StudentMainForm : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        User cur_user;
        public StudentMainForm()
        {
            InitializeComponent();
        }
        public StudentMainForm(User cur_user)
        {
            InitializeComponent();
            this.cur_user = cur_user;
            Student st = db.Students.Where(x => x.id == cur_user.id).FirstOrDefault();
            username.Text = Convert.ToString(st.name_);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Course c = new Course(cur_user);    
            c.Show();
        }

    }
}
