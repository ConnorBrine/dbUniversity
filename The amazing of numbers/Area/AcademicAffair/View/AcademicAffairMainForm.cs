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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class AcademicAffairMainForm : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        public AcademicAffairMainForm()
        {
            InitializeComponent();            
        }
        public AcademicAffairMainForm(User cur_user)
        {
            InitializeComponent();
            this.cur_user = cur_user;
            Academic_Affair aa= db.Academic_Affairs.Where(x=>x.id == cur_user.id).FirstOrDefault();
            username.Text = Convert.ToString(aa.name_);
        }

        private void viewClass_Click(object sender, EventArgs e)
        {
            viewClass v = new viewClass(cur_user);
            v.Show();
        }

        private void viewCourse_Click(object sender, EventArgs e)
        {
            Schedule s = new Schedule();
            s.Show();
        }
    }
}
