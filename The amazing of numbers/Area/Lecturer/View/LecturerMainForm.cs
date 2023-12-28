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

namespace The_amazing_of_numbers.Area.Lecturer.View
{
    public partial class LecturerMainForm : Form
    {
        User cur_user;
        public LecturerMainForm()
        {
            InitializeComponent();
        }
        public LecturerMainForm(User cur_user)
        {
            InitializeComponent();
            this.cur_user = cur_user;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseCourse c = new ChooseCourse(cur_user);
            c.Show();
        }

        private void calendarbtn_Click(object sender, EventArgs e)
        {
            Lecture_Calendar lc = new Lecture_Calendar(cur_user);
            lc.Show();
        }
    }
}
