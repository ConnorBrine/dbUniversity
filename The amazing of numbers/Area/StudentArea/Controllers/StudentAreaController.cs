using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
