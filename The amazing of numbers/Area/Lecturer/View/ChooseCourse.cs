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
using The_amazing_of_numbers.Area.Lecturer.Controllers;
using static The_amazing_of_numbers.Area.Lecturer.Controllers.LecturerController;

namespace The_amazing_of_numbers.Area.Lecturer.View
{
    public partial class ChooseCourse : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        LecturerController LController = new LecturerController();
        Lecture aa = new Lecture();
        public ChooseCourse()
        {
            InitializeComponent();
        }
        public ChooseCourse(User user)
        {
            this.cur_user = user;
            Lecture n = db.Lectures.Where(x => x.id == cur_user.id).FirstOrDefault();
            InitializeComponent();
        }

    }
}
