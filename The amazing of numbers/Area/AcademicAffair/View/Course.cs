using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AcademicAffair.Controllers;
using The_amazing_of_numbers.Area.Admin.Controllers;
using The_amazing_of_numbers.Area.Global;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers
{
    public partial class Course : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        CheckBox HeaderCheckBox = null;
        List<string> sv1 = GlobalClass.sv1;
        List<string> sv2 = GlobalClass.sv2;
        List<string> sv3 = GlobalClass.sv3;
        List<string> sv4 = GlobalClass.sv4;

        
        bool isHeaderCheckBoxClicked = false;
        private User cur_user;
        
        Academic_Affair st;
        AcademicAffairController aaController = new AcademicAffairController();

        List<string> DepartmentData;
        public Course()
        {
            InitializeComponent();
            this.cur_user = new User();
            
            st = db.Academic_Affairs.Where(x => x.id == cur_user.id).FirstOrDefault();
        }
        public Course(User cur_user)
        {
            InitializeComponent();
            this.cur_user = cur_user;
            st = db.Academic_Affairs.Where(x => x.id == cur_user.id).FirstOrDefault();
        }

        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();
            HeaderCheckBox.Size = new Size(15, 15);
            HeaderCheckBox.Location = new Point(HeaderCheckBox.Location.X + 635, HeaderCheckBox.Location.Y + 5);
            this.dataGridView1.Controls.Add(HeaderCheckBox);
        }

        private void HeaderCheckBoxClicked(CheckBox HcheckBox)
        {
            isHeaderCheckBoxClicked = true;

            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                ((DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells["chk"]).Value = HcheckBox.Checked;
            }
           /* foreach(DataGridViewRow Row in dataGridView1.Rows)
            {
            }*/
                
            dataGridView1.RefreshEdit();

            isHeaderCheckBoxClicked = false;

        }
        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClicked((CheckBox)sender);
        }

        private void Course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbEdit.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter2.Fill(this.dbEdit.Subject_);
            // TODO: This line of code loads data into the 'dbEdit.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter1.Fill(this.dbEdit.Class);
            // TODO: This line of code loads data into the 'dBUniversityFullDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dBUniversityFullDataSet.Student);
            // TODO: This line of code loads data into the 'dBUniversityUpdateDataSet.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.dBUniversityUpdateDataSet.Class);
            // TODO: This line of code loads data into the 'dBUniversityUpdateDataSet.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter1.Fill(this.dBUniversityUpdateDataSet.Subject_);
            // TODO: This line of code loads data into the 'dBUniversityDataSet.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.dBUniversityDataSet.Subject_);
            AddHeaderCheckBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            //username.Text = st.name_;
            //ID.Text = st.id;
            //Department.Text = st.department_id;
            
            DepartmentData = aaController.LoadSubject();
            columncmb.Items.Add("All");
            DepartmentData.ForEach(Items => columncmb.Items.Add(Items));
            
        }

        private void updatedateGridView()
        {
           
            string listcourse = "";
            int storeValueCheckBoxSelected = 0;
            float cred = 0;
            long cost = 0;
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                bool checkrow = Convert.ToBoolean(Row.Cells["chk"].Value);
                Console.WriteLine(checkrow);
                if (checkrow)
                {
                    string tmp = Convert.ToString(Row.Cells["coursenameDataGridViewTextBoxColumn"].Value);
                    float numcred = Convert.ToSingle(Row.Cells["creditsDataGridViewTextBoxColumn"].Value);
                    long numcost = Convert.ToInt32(Row.Cells["costDataGridViewTextBoxColumn"].Value);

                    listcourse += tmp + "\n";
                    

                    cred += numcred;
                    cost += numcost;
                    storeValueCheckBoxSelected += 1;
                }
            }
            totCred.Text = Convert.ToString(cred);
            costnum.Text = Convert.ToString(cost);
            numlbl.Text = Convert.ToString(storeValueCheckBoxSelected);
            listcourse_txtbox.AppendText(listcourse);


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updatedateGridView();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Subject_> sub = aaController.SearchingCourseDepart(columncmb.Text);
                var bindingList = new BindingList<Subject_>(sub);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            try
            {
                List<Subject_> sub = aaController.SearchingCourse(textBox1.Text);
                var bindingList = new BindingList<Subject_>(sub);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = semestercmb.Text;
            if (sv1.Contains(value))
            {

            }
        }
    }
}



/*            string comboAssignValue = columncmb.Text;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = 
                    string.Format("course_id like '%" + textBox1.Text + "%'");*/
/*
 course_id
course_name
department_id
credits
cost
 */

/*  if (e.KeyChar == (char)Keys.Enter)
            {
                Console.WriteLine(columncmb.Text + " " + textBox1.Text);

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    subjectBindingSource3.Filter = string.Empty;
                }
                else
                {
                    subjectBindingSource3.Filter = string.Format("{0}='{1}'", columncmb.Text, textBox1.Text);
                }
            }*/