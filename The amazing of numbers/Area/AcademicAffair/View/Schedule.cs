using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using The_amazing_of_numbers.Model;
using The_amazing_of_numbers.Area.AcademicAffair.Controllers;
using static The_amazing_of_numbers.Area.AcademicAffair.Controllers.AcademicAffairController;
using static System.Windows.Forms.Design.AxImporter;
using System.Windows.Media.Animation;
using The_amazing_of_numbers.Controllers;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class Schedule : Form
    {
        string yeardata = "Year 1";
        string apartIDdata = "IT";
        string semesterdata = "1A";
        string dataforcmb;
        string saveclassName;
        bool isReloadPress = false;
        
        Subject_ savesubject = new Subject_();
        weekdata selectiondata = new weekdata();

        dbUniversityDataContext db = new dbUniversityDataContext();
        AcademicAffairController aaController = new AcademicAffairController();
        MatchingController mController = new MatchingController();

        List<string> DepartmentData;
        List<string> selectiondays = new List<string>();

        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBUniversityUpdateDataSet.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.dBUniversityUpdateDataSet.Subject_);
            DepartmentData = aaController.LoadSubject();
            cmbyear.SelectedIndex= 0;
            columncmb.SelectedIndex= 0;
            semestercmb.SelectedIndex= 0;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            option1.Items.Clear();
            option2.Items.Clear();
            fromcmb.Items.Clear();
            infotxtbox.Clear();
            dataforcmb = "";
            saveclassName = "";
            option2.Visible = false;
            txtbox1.Visible = false;
            txtbox2.Visible = false;

            if (e.RowIndex != -1)
            {
                classescmb.Items.Clear();
                DataGridViewRow info = dataGridView1.Rows[e.RowIndex];

                int yearforFirstCode = DateTime.Now.Year;
                if (yeardata == "Year 1") yearforFirstCode -= 1;
                else if (yeardata == "Year 2") yearforFirstCode -= 2;
                else if (yeardata == "Year 3") yearforFirstCode -= 3;
                else yearforFirstCode -= 4;
                yearforFirstCode += 1;


                string print = aaController.printInformation(
                    info.Cells[2].Value.ToString(),
                    info.Cells[3].Value.ToString(),
                    semesterdata,
                    yeardata);
                savesubject = db.Subject_s.Where(s => s.course_name == info.Cells[2].Value.ToString()).FirstOrDefault();


                infotxtbox.AppendText(print);

                className.Text = "";
                string test;
                
                
                for (int i = 1; i <= 1; i++)
                {
                    //Convert.ToInt32(aaController.checkAvailableClasses(yeardata))
                    test = i < 10 ? ("0" + i) : i.ToString();
                    dataforcmb = (yearforFirstCode - 2000) + string.Join("", info.Cells[1].Value.ToString().Take(3)) + "S" 
                        + test + "\n";
                    className.Text += dataforcmb;
                    saveclassName = dataforcmb;
                    classescmb.Items.Add(dataforcmb);
                }
                classescmb.SelectedIndex = 0;
              
                

                selectiondata = aaController.SubjectProp(info.Cells[2].Value.ToString(), info.Cells[3].Value.ToString());
                foreach (datatransfer Item in selectiondata.daysdata)
                {
                    if (!option1.Items.Contains(Item.op1))
                    {
                        option1.Items.Add(Item.op1);
                    }
                    if (!option2.Items.Contains(Item.op2))
                    {
                        option2.Items.Add(Item.op2);
                    }
                    
                }                

                foreach (int Item in selectiondata.timedata)
                {
                    if (!fromcmb.Items.Contains(Item))
                    {
                        fromcmb.Items.Add(Item);
                    }
                       
                    
                }

                option1.Sorted = true;
                option2.Sorted = true;
                fromcmb.Sorted = true;

                classescmb.Visible = true;
                label4.Visible = true;                 
                label8.Visible = true;
                option1.Visible = true;
                fromcmb.Visible = true;
               

                if (selectiondata.daylimit != 1 && !option2.Items.Contains(0))
                {
                    
                   
                    option2.Visible = true;
                    
                }

                option1.SelectedIndex = 0;

                Console.WriteLine("Day: " + selectiondata.daylimit + "      Limittime: " + selectiondata.timelimit + "      Bool" + selectiondata.days_equal_time);
                if (selectiondata.days_equal_time)
                {
                    Console.WriteLine("List ");
                    Console.WriteLine("Count: " + selectiondata.daysdata.Count + " and " + selectiondata.timedata.Count);
                    foreach (datatransfer Item in selectiondata.daysdata)
                    {
                        Console.WriteLine("Day: " + Item.op1 + " - " + Item.op2);
                    }
                    /*"Day: " + selectiondata.daysdata[Item] +*/
                }
               



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbsemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbstudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                isReloadPress = true;

                yeardata = cmbyear.Text;
                apartIDdata = columncmb.Text; 
                semesterdata = semestercmb.Text;
                
                List<string> sub = aaController.SearchByClassFilter(cmbyear.Text, columncmb.Text, semestercmb.Text);
                List<Subject_> result = aaController.StringtoSubject(sub);
                var bindingList = new BindingList<Subject_>(result);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void searchBtn1_Click(object sender, EventArgs e)
        {
            try
            {

                List<Subject_> sub = aaController.SearchingCourse(searchtxtbox.Text);
                var bindingList = new BindingList<Subject_>(sub);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void option2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void option1_SelectedIndexChanged(object sender, EventArgs e)
        {
            option2.Items.Clear();
            foreach (datatransfer Item in selectiondata.daysdata)
            {
               if(Convert.ToInt32(option1.Text) == Item.op1 && !option2.Items.Contains(Item.op2))
                option2.Items.Add(Item.op2);
                
            }
            option2.SelectedIndex = 0;
            option2.Sorted = true;

        }

        private void fromcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbox1.Visible = true;
            txtbox2.Visible = true;

            string result1 = "", result2 = "";

            if(Convert.ToInt32(fromcmb.Text) == 1)
            {
                result1 = "ca 1: 6h45";
            }
            else if (Convert.ToInt32(fromcmb.Text) == 2)
            {
                result1 = "ca 2: 9h20";
            }
            else if (Convert.ToInt32(fromcmb.Text) == 3)
            {
                result1 = "ca 3: 12h30";
            }
            else if(Convert.ToInt32(fromcmb.Text) == 4)
            {
                result1 = "ca 4: 15h05";
            }
            if(selectiondata.isDP == 2 && selectiondata.isDP == 3)
            {
                result1 = "tiết 4 - 5: 9h20";
            }
            

            result2 = aaController.getTime(Convert.ToInt32(fromcmb.Text), selectiondata.daylimit);
            txtbox1.Clear();
            txtbox2.Clear();
            txtbox1.AppendText(result1);
            txtbox2.AppendText(result2);
        }
        private void calender_OnClick(object sender, EventArgs e)
        {
            Panel p = new Panel();
            p = sender as Panel;
            if (p.BackColor == Color.PaleTurquoise)
            {
                p.BackColor = Color.LightGray;
                selectiondays.Remove(p.Tag.ToString());
            }
            else
            {
                p.BackColor = Color.PaleTurquoise;
                selectiondays.Add(p.Tag.ToString());
            }

        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            mController.aaController(savesubject, selectiondays, saveclassName);
            MessageBox.Show("Add Successfully!");
        }
    }

}
