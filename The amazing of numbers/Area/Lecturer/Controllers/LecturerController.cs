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
    }
}
