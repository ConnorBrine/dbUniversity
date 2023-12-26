using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_amazing_of_numbers.Area.Admin.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Admin.Controllers
{
    internal class AdminController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        public void AdminHomeView(User user_model)
        {
            cur_user = user_model;  
            new AdminMainForm(cur_user.id).Show();
        }
        public void AddingPIN(string PIN, string id)
        {
            //Console.WriteLine("User id: " + id);
            try {
                User user_model = db.Users.Where(user => user.id == id).FirstOrDefault();
                if (user_model != null)
                {
                    user_model.pin = PIN;
                    db.SubmitChanges();
                }
                
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
