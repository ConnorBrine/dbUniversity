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
using The_amazing_of_numbers.Area.AcademicAffair.Controllers;
using Guna.UI2.AnimatorNS;
using static The_amazing_of_numbers.Area.AcademicAffair.Controllers.AcademicAffairController;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class AcademicAffair_Stat : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        AcademicAffairController aaController = new AcademicAffairController();

        List<ProgressStudent> allavailableProgressStudent = new List<ProgressStudent>();
        //this will be sort

        List<Student> defaultStudentlist = new List<Student>();
        //data need to store and sort upper ^^^
        public AcademicAffair_Stat()
        {
            InitializeComponent();
            
        }

        private void AcademicAffair_Stat_Load(object sender, EventArgs e)
        {            
            stu_yearcmb.SelectedIndex = 0;
            defaultStudentlist = aaController.allStudent("All");
            var bindingList = new BindingList<Student>(defaultStudentlist);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

        }

        private void stu_yearcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("---------------------------------------------------Reset---------------------------------------------------");
            defaultStudentlist = aaController.allStudent(stu_yearcmb.Text);            
            allavailableProgressStudent = aaController.resultStudentEachSemester(defaultStudentlist);
            var bindingList = new BindingList<Student>(defaultStudentlist);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
        private void Ascending(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            allavailableProgressStudent = aaController.sortStudent(allavailableProgressStudent, true, btn.Tag.ToString());
            defaultStudentlist = aaController.applySort(defaultStudentlist, allavailableProgressStudent);
            var bindingList = new BindingList<Student>(defaultStudentlist);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
        private void Descending(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            allavailableProgressStudent = aaController.sortStudent(allavailableProgressStudent, false, btn.Tag.ToString());
            defaultStudentlist = aaController.applySort(defaultStudentlist, allavailableProgressStudent);
            var bindingList = new BindingList<Student>(defaultStudentlist);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void top10btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            List<ProgressStudent> top10 = aaController.getTop10(allavailableProgressStudent);
            defaultStudentlist = aaController.applySort(defaultStudentlist, top10);
            var bindingList = new BindingList<Student>(defaultStudentlist);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
    }
}
