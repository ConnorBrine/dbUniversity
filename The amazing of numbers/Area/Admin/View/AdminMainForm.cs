using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.Admin.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Admin.View
{
    public partial class AdminMainForm : Form
    {
        AdminController adminController = new AdminController();
        private string id = string.Empty;
        public AdminMainForm(string user_id)
        {
            //Console.WriteLine("User id: " + user_id);
            id = user_id;
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string PIN = PINbar.Text;
            //Console.WriteLine("User id: " + id);
            adminController.AddingPIN(PIN,id);

        }
    }
}
