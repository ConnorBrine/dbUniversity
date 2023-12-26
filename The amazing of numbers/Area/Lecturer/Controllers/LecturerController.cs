using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_amazing_of_numbers.Area.Admin.View;
using The_amazing_of_numbers.Area.Lecturer.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Lecturer.Controllers
{
    internal class LecturerController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        public void LecturerHomeView(User user_model)
        {
            cur_user = user_model;
            new LecturerMainForm().Show();
        }
    }
}
