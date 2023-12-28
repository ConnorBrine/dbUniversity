using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Controllers
{
 
    internal class MatchingController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        
        public void aaController(Subject_ subject, List<string> section, string className) 
        {
            Academic_AffairPickDay pickday;
            foreach (var item in section)
            {
                pickday = new Academic_AffairPickDay();
                pickday.course_id = subject.course_id;
                pickday.course_name = subject.course_name;
                pickday.section = item;
                pickday.class_name = className;

                
                db.Academic_AffairPickDays.InsertOnSubmit(pickday);
                db.SubmitChanges();

            }
            
            
        }
        public void registerStudent(Student student, string classID) 
        {
            StudentRegisClass src = new StudentRegisClass();

                src.id = student.id;
                src.class_id = classID;
                src.date_register = DateTime.Now;
                src.status_ = "đã đăng ký";
                src.score = 0;
                src.tuition_status = 0;

            try
            {
                db.StudentRegisClasses.InsertOnSubmit(src);
                db.SubmitChanges();
                MessageBox.Show("Add Succesfully");
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
                MessageBox.Show("This class you register is already exist");
            }




        }
    }
}
