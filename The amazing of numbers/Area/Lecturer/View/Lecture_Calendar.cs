using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.StudentArea.Controllers;
using The_amazing_of_numbers.Model;
using The_amazing_of_numbers.Area.Lecturer.Controllers;

namespace The_amazing_of_numbers.Area.Lecturer.View
{
    public partial class Lecture_Calendar : Form
    {
        User cur_user;
        Dictionary<string, string> allcourse_day = new Dictionary<string, string>();

        LecturerController lController = new LecturerController();

        Subject_ s;
        OpenClass o;
        Class cl;

        dbUniversityDataContext db = new dbUniversityDataContext();
        public Lecture_Calendar()
        {
            InitializeComponent();
        }

        public Lecture_Calendar(User user)
        {
            this.cur_user = user;
            InitializeComponent();
        }

        private void Calender_Load(object sender, EventArgs e)
        {
            allcourse_day = lController.CalendarSetup(cur_user.id);
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
    }
}
