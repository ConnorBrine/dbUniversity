using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_amazing_of_numbers.Area.Admin.View;
using The_amazing_of_numbers.Area.Lecturer.View;
using The_amazing_of_numbers.Model;
using The_amazing_of_numbers.Area.Global;

namespace The_amazing_of_numbers.Area.Lecturer.Controllers
{
    internal class LecturerController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;

        Subject_ s;
        Class c;
        OpenClass oc;
        List<LectureRegisClass> lrc;
        Dictionary<string, string> all_calendar_data = new Dictionary<string, string>();

        public void LecturerHomeView(User user_model)
        {
            cur_user = user_model;
            new LecturerMainForm(user_model).Show();
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

        public Dictionary<string, string> CalendarSetup(string lecture_id)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            string tmp = "";

            lrc = db.LectureRegisClasses.Where(x => x.id == lecture_id
                                                 && x.status_ == "Đang hoạt động"
            ).ToList();
            //get list of all active class
            foreach (var item in lrc)
            {
                c = db.Classes.Where(x => x.class_id == item.class_id).FirstOrDefault(); 
                oc = db.OpenClasses.Where(x => x.class_id == item.class_id).FirstOrDefault();
                //s = db.Subject_s.Where(x => x.course_id == oc.course_id).FirstOrDefault();
                Console.WriteLine(c.date_start);
                if (c.section_start <= new TimeSpan(15, 05, 00))
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
