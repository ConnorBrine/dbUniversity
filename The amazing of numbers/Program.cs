using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AcademicAffair.View;
using The_amazing_of_numbers.Area.Admin.View;
using The_amazing_of_numbers.Area.Global;
using The_amazing_of_numbers.Area.StudentArea.View;

namespace The_amazing_of_numbers
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Schedule());
            Application.Run(new Login());
            //Application.Run(new JoinClasses());

        }
    }
}
