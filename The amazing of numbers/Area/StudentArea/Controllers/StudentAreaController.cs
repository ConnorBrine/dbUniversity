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

namespace The_amazing_of_numbers.Area.StudentArea.Controllers
{
    internal class StudentAreaController
    {
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
    }
}
