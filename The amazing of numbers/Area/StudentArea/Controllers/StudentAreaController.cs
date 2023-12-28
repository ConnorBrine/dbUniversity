using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.Global;
using The_amazing_of_numbers.Area.Lecturer.View;
using The_amazing_of_numbers.Area.StudentArea.View;
using The_amazing_of_numbers.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace The_amazing_of_numbers.Area.StudentArea.Controllers
{
    internal class StudentAreaController
    {
        Subject_ s;
        Class c;
        OpenClass oc;
        List<StudentRegisClass> src;
        Dictionary<string, string> all_calendar_data = new Dictionary<string, string>();

        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        public void StudentHomeView(User user_model)
        {
            Console.WriteLine();                                                                                                                                    
            cur_user = user_model;
            Console.WriteLine("Current: " + cur_user.id);
            new StudentMainForm(cur_user).Show();
        }
        public User getUser()
        {
            return cur_user;
        }

        public List<string> allCourse(int semester, int year)
        {
            List<string> list = new List<string>();
            if (semester == 1)
            {
                list = GlobalClass.sv1_HK1A_IT;
                list.AddRange(GlobalClass.sv1_HK1A_Practice);
                list.AddRange(GlobalClass.sv1_HK1A_DP);
                list.AddRange(GlobalClass.sv1_HK1A_TA);
                list.AddRange(GlobalClass.sv1_HK1B_IT);
                list.AddRange(GlobalClass.sv1_HK1B_Math);
                list.AddRange(GlobalClass.sv1_HK1B_Extra);
                list.AddRange(GlobalClass.sv1_HK1B_TA);
            }
            else
            {
                //skip
            }
            return list;
        }
        public Dictionary<string, string> CalendarSetup(string student_id)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            string tmp = "";
            
            src = db.StudentRegisClasses.Where(x => x.id == student_id 
                                                 && x.status_ == "Đang học"
                                                 && x.tuition_status == 1
            ).ToList();

            foreach(var item in src)
            {
                c = db.Classes.Where(x => x.class_id == item.class_id).FirstOrDefault();
                oc = db.OpenClasses.Where(x => x.class_id == item.class_id).FirstOrDefault();
                //s = db.Subject_s.Where(x => x.course_id == oc.course_id).FirstOrDefault();
                Console.WriteLine(c.date_start);
                if (c.section_start <= new TimeSpan(15,05,00))
                {                  
                    if (c.section_start <= new TimeSpan(12, 30, 00))
                    {
                        if (c.section_start <= new TimeSpan(9, 20, 00))
                        {
                            if (c.section_start == new TimeSpan(6, 45, 00))
                            {
                                tmp = "C1";
                            }
                            else tmp = "C2";
                        }
                        else tmp = "C3";
                    }
                    else tmp = "C4";
                }
                var tmp2 = c.days_.Split('-');
                list.Add(tmp + tmp2[0], item.class_id);
                list.Add(tmp + tmp2[1], item.class_id);
            }
            
            return list;
        }
    }
}
