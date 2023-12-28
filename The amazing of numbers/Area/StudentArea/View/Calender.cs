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
using The_amazing_of_numbers.Area.StudentArea.Controllers;

namespace The_amazing_of_numbers.Area.StudentArea.View
{
    public partial class Calender : Form
    {
        User cur_user;
        Dictionary<string, string> allcourse_day = new Dictionary<string, string>();

        StudentAreaController stuareaController = new StudentAreaController();

        Subject_ s;
        OpenClass o;
        Class cl;

        dbUniversityDataContext db = new dbUniversityDataContext();

        public Calender()
        {
            InitializeComponent();
        }
        public Calender(User user)
        {
            this.cur_user = user;
            InitializeComponent();
        }
        private void Calender_Load(object sender, EventArgs e)
        {
            allcourse_day = stuareaController.CalendarSetup(cur_user.id);
            Console.WriteLine(allcourse_day.Count);
            foreach (var item in allcourse_day)
            {
                Console.WriteLine(item);
                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    if (c.Name == item.Key)
                    {
                        //key now: class_id
                        o = db.OpenClasses.Where(x => x.class_id == item.Value).FirstOrDefault(); //get course_id
                        cl = db.Classes.Where(x => x.class_id == item.Value).FirstOrDefault(); //get room
                        s = db.Subject_s.Where(x => x.course_id == o.course_id).FirstOrDefault(); //get course_name
                        c.Text = item.Value + "\n" + //lớp 
                            o.course_id + "\n" +  //mã môn
                            s.course_name + "\n" + //môn
                            cl.room; 

                    }

                }
            }
           
        }

        private void C1T5_TextChanged(object sender, EventArgs e)
        {

        }

        private void C1T6_TextChanged(object sender, EventArgs e)
        {

        }

        private void C1T7_TextChanged(object sender, EventArgs e)
        {

        }

        private void C1T8_TextChanged(object sender, EventArgs e)
        {

        }

        private void C2T7_TextChanged(object sender, EventArgs e)
        {

        }

        private void C2T6_TextChanged(object sender, EventArgs e)
        {

        }

        private void C2T5_TextChanged(object sender, EventArgs e)
        {

        }

        private void C2T4_TextChanged(object sender, EventArgs e)
        {

        }

        private void C2T3_TextChanged(object sender, EventArgs e)
        {

        }

        private void C2T2_TextChanged(object sender, EventArgs e)
        {

        }

        private void C3T2_TextChanged(object sender, EventArgs e)
        {

        }

        private void C3T3_TextChanged(object sender, EventArgs e)
        {

        }

        private void C3T4_TextChanged(object sender, EventArgs e)
        {

        }

        private void C3T5_TextChanged(object sender, EventArgs e)
        {

        }

        private void C3T6_TextChanged(object sender, EventArgs e)
        {

        }

        private void C3T7_TextChanged(object sender, EventArgs e)
        {

        }

        private void C3T8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
