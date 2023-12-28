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
using System.Globalization;
using The_amazing_of_numbers.Area.Global;
using The_amazing_of_numbers.Area.StudentArea.Controllers;
using The_amazing_of_numbers.Controller;
using The_amazing_of_numbers.Controllers;

namespace The_amazing_of_numbers.Area.StudentArea.View
{
    public partial class JoinClasses : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();

        StudentAreaController SController = new StudentAreaController();
        MatchingController MatchingController = new MatchingController();

        Panel Panelcheck = null;


        OpenClass openc;
        Class c;
        LectureRegisClass lectureReg;
        Subject_ getSubject;
        Lecture lecture;

        User cur_user;

        List<string> classes = new List<string>();
        List<string> classesIDdata = new List<string>();
        string classesID_choose = "";
        int classID_index;

        public JoinClasses()
        {
            InitializeComponent();
        }
        public JoinClasses(User user)
        {
            this.cur_user = user;   
            InitializeComponent();
        }
        private void calender_OnClick(object sender, EventArgs e)
        {
            infotxtbox.Clear();
            //classesIDdata data
            Panel p = new Panel();
            p = sender as Panel;
            if (p.BackColor == Color.LightGray)
            {
                if(Panelcheck != null)
                {
                    Panelcheck.BackColor = Color.LightGray;                    
                }

                if(p.Tag.ToString() == "idx1")
                {
                    classID_index = 0;
                    infotxtbox.Text = classes[0];
                }
                else if (p.Tag.ToString() == "idx2")
                {
                    classID_index = 1;
                    infotxtbox.Text = classes[1];
                }
                else if (p.Tag.ToString() == "idx3")
                {
                    classID_index = 2;
                    infotxtbox.Text = classes[2];
                }
                else if (p.Tag.ToString() == "idx4")
                {
                    classID_index = 3;
                    infotxtbox.Text = classes[3];
                }
                int tmp = classID_index + 1;
                label2.Text = "Lớp học ở ô "+ tmp.ToString();
                p.BackColor = Color.PaleTurquoise;
                Panelcheck = p;
            }
            else //p.BackColor = Color.PaleTurquoise; 
            {
                p.BackColor = Color.LightGray;
                Panelcheck = null;
                classID_index = -1;
                label2.Text = "Chưa có lớp nào";

            }

            //p.BackColor = Color.LightGray; 
            //uncheck
            //p.BackColor = Color.PaleTurquoise;
            //check
        }

        private void JoinClasses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBUniversityUpdate2DataSet.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter1.Fill(this.dBUniversityUpdate2DataSet.Subject_);
            flowLayoutPanel1.Visible = false;
            int changehere = 1;


            List<string> allcourse = SController.allCourse(changehere, 1);
            allcourse.ForEach(Items => columncmb.Items.Add(Items));

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  

        }

        private void columncmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cell1.Visible = false;
            cell2.Visible = false;
            cell3.Visible = false;
            cell4.Visible = false;
            O1.Visible = false;
            O2.Visible = false;
            O3.Visible = false;
            O4.Visible = false;
            classes.Clear();
            classesIDdata.Clear();

            flowLayoutPanel1.Visible = true;
            string courseName = columncmb.Text;
            string course_id = "";
            getSubject = db.Subject_s.Where(x => x.course_name == courseName).FirstOrDefault();
            course_id = getSubject.course_id;
            List<OpenClass> test = db.OpenClasses.Where(x => x.course_id == course_id).ToList();
            

            foreach (var item in test)
            {
                c = db.Classes.Where(x => x.class_id == item.class_id).FirstOrDefault();
                lectureReg = db.LectureRegisClasses.Where(x => x.class_id == item.class_id).FirstOrDefault();
                lecture = db.Lectures.Where(x => x.id == lectureReg.id).FirstOrDefault();

                string time = "";
               
                if (c.date_start <= DateTime.Parse("15:05:00"))
                {
                    if (c.date_start <= DateTime.Parse("12:30:00"))
                    {
                        if (c.date_start <= DateTime.Parse("9:20:00"))
                        {
                            if (c.date_start == DateTime.Parse("6:45:00"))
                            {
                                time = "1";
                            }
                            else time = "2";
                        }
                        else time = "3";
                    }
                    else time = "4";
                }

                classes.Add(getSubject.course_name +
                    "           " + "mã môn học: " + course_id +
                    "           " + "mã lớp: " + c.class_id +
                    "           " + "số tín chỉ: " + getSubject.credits +
                    "           " + "giảng viên: " + lecture.name_ +
                    "           " + "Ca: " + time +
                    "           " + "Thứ: " + c.days_ +
                    "           " + "Phòng " + c.room +
                    "           " + "21/8 - 22/10"
                    );
                classesIDdata.Add(c.class_id);

            }
            //
            int check = classes.Count;

            for (int i = 1; i <= check; i++)
            {
                switch (i)
                {
                    case 1:
                        cell1.Visible = true;
                        O1.Visible = true;
                        O1.Text = classes[0];                        
                        break;
                    case 2:
                        cell2.Visible = true;
                        O2.Visible = true;
                        O2.Text = classes[1];
                        break;
                    case 3:
                        cell3.Visible = true;
                        O3.Visible = true;
                        O3.Text = classes[2];
                        break;
                    case 4:
                        cell4.Visible = true;
                        O4.Visible = true;
                        O4.Text = classes[3];
                        break;
                }

            }


        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            Student st = db.Students.Where(x => x.id == cur_user.id).FirstOrDefault();

            //thêm 1 th là sv đăng ký môn đó r mà vẫn dk kíp môn khác
            if (Panelcheck == null || classID_index == -1)
            {
                MessageBox.Show("You don't choose anything, please try again");
            }
            else
            {

                    MatchingController.registerStudent(st, classesIDdata[classID_index]);
                    

            }
            
        }
    }
}
