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
        int indexLearningScore = 6;
        int indexTrainingScore = 7;
        int indexNoOfViolations = 8;

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
            // TODO: This line of code loads data into the 'dBUniversityUpdate2DataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dBUniversityUpdate2DataSet2.Student);
            stu_yearcmb.SelectedIndex = 0;
            defaultStudentlist = aaController.allStudent("All");
            allavailableProgressStudent = aaController.resultStudentEachSemester(defaultStudentlist);
            //allavailableProgressStudent --> Lấy điểm phù hợp theo ID

            var bindingList = new BindingList<Student>(defaultStudentlist);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            Console.WriteLine(dataGridView1.Rows.Count + " and " + allavailableProgressStudent.Count);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                //Phải đúng người dùng 
                 dataGridView1.Rows[i].Cells[indexLearningScore].Value = allavailableProgressStudent[i].learningscore;
                 dataGridView1.Rows[i].Cells[indexTrainingScore].Value = allavailableProgressStudent[i].trainingscore;
                 dataGridView1.Rows[i].Cells[indexNoOfViolations].Value = allavailableProgressStudent[i].numVio;
                Console.WriteLine(allavailableProgressStudent[i].learningscore + " - " + allavailableProgressStudent[i].trainingscore + " - " + allavailableProgressStudent[i].numVio);
                Console.WriteLine("Test: " + dataGridView1.Rows[i].Cells[0].Value);

            }
        }

        private void stu_yearcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("---------------------------------------------------Reset---------------------------------------------------");
            defaultStudentlist = aaController.allStudent(stu_yearcmb.Text);            
            allavailableProgressStudent = aaController.resultStudentEachSemester(defaultStudentlist);
            BindingList<Student> bindingList = new BindingList<Student>(defaultStudentlist);
            BindingSource source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                //Phải đúng người dùng 
                dataGridView1.Rows[i].Cells[indexLearningScore].Value = allavailableProgressStudent[i].learningscore;
                dataGridView1.Rows[i].Cells[indexTrainingScore].Value = allavailableProgressStudent[i].trainingscore;
                dataGridView1.Rows[i].Cells[indexNoOfViolations].Value = allavailableProgressStudent[i].numVio;
                Console.WriteLine(allavailableProgressStudent[i].learningscore + " - " + allavailableProgressStudent[i].trainingscore + " - " + allavailableProgressStudent[i].numVio);
                Console.WriteLine("Test: " + dataGridView1.Rows[i].Cells[0].Value);

            }
        }
        private void checkAsc_or_Desc(object sender, EventArgs e)
        {
            ComboBox cmb = new ComboBox();
            cmb = sender as ComboBox;
            if (cmb.Text == "Tăng dần") Ascending(cmb.Tag.ToString());
            else Descending(cmb.Tag.ToString());
        }
        private void Ascending(string filterLocation)
        {
            
            allavailableProgressStudent = aaController.sortStudent(allavailableProgressStudent, true, filterLocation);
            defaultStudentlist = aaController.applySort(defaultStudentlist, allavailableProgressStudent);
            BindingList<Student> bindingList = new BindingList<Student>(defaultStudentlist);
            BindingSource source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                //Phải đúng người dùng 
                dataGridView1.Rows[i].Cells[indexLearningScore].Value = allavailableProgressStudent[i].learningscore;
                dataGridView1.Rows[i].Cells[indexTrainingScore].Value = allavailableProgressStudent[i].trainingscore;
                dataGridView1.Rows[i].Cells[indexNoOfViolations].Value = allavailableProgressStudent[i].numVio;
                Console.WriteLine(allavailableProgressStudent[i].learningscore + " - " + allavailableProgressStudent[i].trainingscore + " - " + allavailableProgressStudent[i].numVio);
                Console.WriteLine("Test: " + dataGridView1.Rows[i].Cells[0].Value);

            }

        }
        private void Descending(string filterLocation)
        {
            
            allavailableProgressStudent = aaController.sortStudent(allavailableProgressStudent, false, filterLocation);
            defaultStudentlist = aaController.applySort(defaultStudentlist, allavailableProgressStudent);
            BindingList<Student> bindingList = new BindingList<Student>(defaultStudentlist);
            BindingSource source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                //Phải đúng người dùng 
                dataGridView1.Rows[i].Cells[indexLearningScore].Value = allavailableProgressStudent[i].learningscore;
                dataGridView1.Rows[i].Cells[indexTrainingScore].Value = allavailableProgressStudent[i].trainingscore;
                dataGridView1.Rows[i].Cells[indexNoOfViolations].Value = allavailableProgressStudent[i].numVio;
                Console.WriteLine(allavailableProgressStudent[i].learningscore + " - " + allavailableProgressStudent[i].trainingscore + " - " + allavailableProgressStudent[i].numVio);
                Console.WriteLine("Test: " + dataGridView1.Rows[i].Cells[0].Value);

            }
        }

        private void top10btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            List<ProgressStudent> top10 = aaController.sortStudent(allavailableProgressStudent, false, "Top10");
            defaultStudentlist = aaController.applySort(defaultStudentlist, top10);
            BindingList<Student> bindingList = new BindingList<Student>(defaultStudentlist);
            BindingSource source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                //Phải đúng người dùng 
                dataGridView1.Rows[i].Cells[indexLearningScore].Value = top10[i].learningscore;
                dataGridView1.Rows[i].Cells[indexTrainingScore].Value = top10[i].trainingscore;
                dataGridView1.Rows[i].Cells[indexNoOfViolations].Value = top10[i].numVio;
                Console.WriteLine(top10[i].learningscore + " - " + top10[i].trainingscore + " - " + top10[i].numVio);
                Console.WriteLine("Test: " + dataGridView1.Rows[i].Cells[0].Value);

            }

        }
    }
}
